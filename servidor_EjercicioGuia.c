#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>
#include <ctype.h>

int i;
int sockets[100];

void* AtenderCliente(void* socket)
{
    int sock_conn;
    int* s;
    s = (int*)socket;
    sock_conn = *s;

    char peticion[512];
    char respuesta[512];
    int ret;

    int terminar = 0;
    while (terminar == 0)
    {
        ret = read(sock_conn, peticion, sizeof(peticion));
        if (ret <= 0)
        {
            terminar = 1;
        }
        else
        {
            peticion[ret] = '\0';
            printf("Peticion: %s\n", peticion);

            char* p = strtok(peticion, "/");
            int codigo = atoi(p);
            char nombre[30] = "";
            char altura_str[30] = "";
            int altura = 0;

            if (codigo != 0)
            {
                p = strtok(NULL, "/");
                if (p != NULL)
                    strcpy(nombre, p);
            }

            if (codigo == 0)
            {
                terminar = 1;
            }
            else if (codigo == 1) // nombre bonito
            {
                printf("Codigo: %d, Nombre: %s\n", codigo, nombre);
                if ((nombre[0] == 'M') || (nombre[0] == 'S'))
                    sprintf(respuesta, "%s es un nombre bonito", nombre);
                else
                    sprintf(respuesta, "%s no es un nombre bonito", nombre);
            }
            else if (codigo == 2) // longitud
            {
                printf("Codigo: %d, Nombre: %s\n", codigo, nombre);
                sprintf(respuesta, "La longitud de %s es %d", nombre, (int)strlen(nombre));
            }
            else if (codigo == 3) // altura
            {
                p = strtok(NULL, "/");
                if (p != NULL)
                    strcpy(altura_str, p);
                altura = atoi(altura_str);

                printf("Codigo: %d, Nombre: %s, Altura: %d\n", codigo, nombre, altura);

                if (altura > 170)
                    sprintf(respuesta, "%s es alto", nombre);
                else
                    sprintf(respuesta, "%s no es alto", nombre);
            }
            else if (codigo == 4) // palíndromo
            {
                printf("Codigo: %d, Nombre: %s\n", codigo, nombre);
                int len = strlen(nombre);
                int esPal = 1;
                for (int j = 0; j < len / 2 && esPal; j++)
                {
                    if (tolower((unsigned char)nombre[j]) != tolower((unsigned char)nombre[len - 1 - j]))
                        esPal = 0;
                }
                if (esPal)
                    sprintf(respuesta, "El nombre %s SÍ es palíndromo", nombre);
                else
                    sprintf(respuesta, "El nombre %s NO es palíndromo", nombre);
            }
            else if (codigo == 5) // mayúsculas
            {
                printf("Codigo: %d, Nombre: %s\n", codigo, nombre);
                for (int j = 0; nombre[j]; j++)
                    nombre[j] = toupper((unsigned char)nombre[j]);
                sprintf(respuesta, "En mayúsculas: %s", nombre);
            }
            else
            {
                sprintf(respuesta, "Código no reconocido");
            }

            if (codigo != 0)
            {
                write(sock_conn, respuesta, strlen(respuesta));
            }
        }
    }
    close(sock_conn);
    return NULL;
}

int main(int argc, char* argv[])
{
    int sock_listen;
    int sock_conn;
    struct sockaddr_in serv_adr;

    sock_listen = socket(AF_INET, SOCK_STREAM, 0);
    if (sock_listen < 0)
    {
        printf("Error al crear socket\n");
        return -1;
    }

    memset(&serv_adr, 0, sizeof(serv_adr));
    serv_adr.sin_family = AF_INET;
    serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
    serv_adr.sin_port = htons(50000);

    if (bind(sock_listen, (struct sockaddr*)&serv_adr, sizeof(serv_adr)) < 0)
    {
        printf("Error al bind\n");
        return -1;
    }

    if (listen(sock_listen, 3) < 0)
    {
        printf("Error en el Listen\n");
        return -1;
    }

    printf("Escuchando\n");

    i = 0;

    for (;;)
    {
        sock_conn = accept(sock_listen, NULL, NULL);
        printf("He recibido conexión\n");
        sockets[i] = sock_conn;
        pthread_t thread;
        pthread_create(&thread, NULL, AtenderCliente, &sockets[i]);
        i = i + 1;
    }
}

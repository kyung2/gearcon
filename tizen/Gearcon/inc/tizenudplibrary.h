#ifndef _TIZENUDPLIBRARY_H_
#define _TIZENUDPLIBRARY_H_

/**
 * This header file is included to define _EXPORT_.
 */
#include <stdbool.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <Ecore.h>
#include <netdb.h>
#include <arpa/inet.h>
#include <dlog.h>
#include <Elementary.h>
#include <unistd.h>
#include <stdlib.h>
#include <string.h>
#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#define BUFF_SIZE 512
#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "TUL"
#define TUL_NOT_CONNECTED 0
#define TUL_RECEIVED 1
#define TUL_CONNECTED 2

#define TUL_CONNECTED_LOCAL 1
#define TUL_CONNECTED_GLOBAL 2
#define TUL_CONNECTED_RELAY 3
#ifdef __cplusplus
extern "C" {
#endif

// This method is exported from tizenudplibrary.a
int send_packet(struct sockaddr_in to_send,char * message,int message_len);
void tul_listen(void *data, Ecore_Thread *thread);
void tul_connect_other(void *data, Ecore_Thread *thread);
void tul_listen_end(void *data, Ecore_Thread *thread);
void tul_listen_cancel(void *data, Ecore_Thread *thread);

extern int tul_send(char * message,int message_len);


extern int tul_bind_port(int port);

extern int tul_connect(char * token,char * id);

extern int tul_enroll(char * token,char * id);

extern int tul_start_listen(Ecore_Thread_Notify_Cb callback, void * data);

extern int tul_stop_listen();

extern int tul_init(char * server_ip,int port);

extern int tul_add_listen_callback(void(* callBack)(void *, Ecore_Thread *, void *));

extern int tul_get_time_id(char ** id);

extern int tul_enroll(char * token,char * id);

#ifdef __cplusplus
}
#endif
#endif // _TIZENUDPLIBRARY_H_


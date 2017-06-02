#ifndef __gearcon_H__
#define __gearcon_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "gearcon"

#if !defined(PACKAGE)
#define PACKAGE "org.example.gearcon"
#endif

#define EDJ_FILE "edje/gearcon.edj"
#define GRP_MAIN "main"


#endif /* __gearcon_H__ */

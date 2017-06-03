#ifndef __gearcon_H__
#define __gearcon_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

//#define EDJ_FILE "/opt/usr/apps/org.example.gearcon_m/res/gearcon_m.edj"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "gearcon"

#if !defined(PACKAGE)
#define PACKAGE "org.example.gearcon"
#endif
//res?
#define EDJ_FILE "/edje/gearcon.edj"
#define GRP_MAIN "main"
#define ICON_DIR "/opt/usr/apps/org.example.gearcon/res/images"
//void _popup_hide_cb(void *data, Evas_Object *obj, void *event_info);

//void _popup_hide_finished_cb(void *data, Evas_Object *obj, void *event_info);
static char _key_get(void *data, Evas_Object *obj,const char *part);
void set_pckey(void *data, char * text);
void my_A_cb (void *dataz);
void bottom_button_cb(void *data, Evas_Object * obj, void *event_info);
void view_PC_Setting(void *data);
void view_app_info(void *data);
void view_control_volume(void *data);
void view_control_pdf(void *data);
void view_control_ppt(void *data);
void view_control_mouse(void *data);
void view_control_player(void *data);
void view_connect(void *data);
void view_disconnect(void *data);
void view_pcoff(void *data);
void view_control_brightness(void *data);
void view_control_keyboard(void *data);
//elm_box_padding_set(box, 0, 1* elm_config_scale_get()); (여백 사이즈)


void progressbar_cb(void *data, Evas_Object * obj, void *event_info);

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *layout;
	Evas_Object *label;
	Evas_Object *nf;
	Evas_Object *button;
	Eext_Circle_Surface *circle_surface;
	Evas_Object *rs;
	Evas_Object *genlist;
	Evas_Object *circle_genlist;
	Evas_Object *parent;
	Evas_Object *image;
	Evas_Object *box;
	char *text;
	// mouse point
	Evas_Coord_Point ex_point;

	//using pc_setting
} appdata_s;


struct _menu_item {
   char *name;
   void (*func)(void *data, Evas_Object *obj, void *event_info);
};


#endif /* __gearcon_H__ */

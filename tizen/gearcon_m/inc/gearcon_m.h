#ifndef __gearcon_m_H__
#define __gearcon_m_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "gearcon_m"

#if !defined(PACKAGE)
#define PACKAGE "org.example.gearcon_m"
#endif

#define EDJ_FILE "/opt/usr/apps/org.example.gearcon_m/res/gearcon_m.edj"
#define GRP_MAIN "main"
#define ICON_DIR "/opt/usr/apps/org.example.gearcon_m/res/images"

//void _popup_hide_cb(void *data, Evas_Object *obj, void *event_info);

//void _popup_hide_finished_cb(void *data, Evas_Object *obj, void *event_info);
static char _key_get(void *data, Evas_Object *obj,const char *part);
void set_pckey(void *data, char * text);
void my_A_cb (void *data);
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
	Evas_Object *point;
	Evas_Object *rect;



	//using pc_setting
} appdata_s;


struct _menu_item {
   char *name;
   void (*func)(void *data, Evas_Object *obj, void *event_info);
};

struct Elm_Gesture_Momentum_Info {
    Evas_Coord x1; /* Final-swipe direction with starting point on X */
    Evas_Coord y1; /* Final-swipe direction with starting point on Y */
    Evas_Coord x2; /* Final-swipe direction with ending point on X */
    Evas_Coord y2; /* Final-swipe direction with ending point on Y */

    unsigned int tx; /* Timestamp of the start of the final X swipe */
    unsigned int ty; /* Timestamp of the start of the final Y swipe */

    Evas_Coord mx; /* Momentum on X */
    Evas_Coord my; /* Momentum on Y */

    unsigned int n; /* Number of fingers */
};



#endif /* __gearcon_m_H__ */

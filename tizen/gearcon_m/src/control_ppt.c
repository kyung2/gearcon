/*
 *hyunkyung
 */
#include "gearcon_m.h"
#include <stdio.h>
#include <Elementary.h>
#include <dlog.h>

#define ICON_WIDTH 80
#define ICON_HEIGHT 80


Evas_Object *entry;
Evas_Object *box;


typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;


static float get_entry_value()
{
	char* text = elm_object_text_get(entry);
	float value = atof(text);
	return value;
}

static void
append_number_label(char str_new)
{
	char buf[100];


    char* text = elm_object_text_get(entry);
    float value = get_entry_value();
    if( value == 0.f )
    	 sprintf(buf, "%c", str_new);
    else
    	sprintf(buf, "%s%c", text, str_new);

    elm_object_text_set(entry, buf);
}

static void
prev_btn_clicked_cb(void *data, Evas_Object *obj, void *event_ifo)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"prev button (play)");
}

static void
next_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"next button (play)");
}

static void
show_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"show button (ppt)");

}
static void
play_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"pl button (play)");
}

static void
stop_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"stop button (play)");
}
/*
static Evas_Object*
create_scroller(Evas_Object *parent)
{
	Evas_Object *scroller = elm_scroller_add(parent);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	return scroller;
}
*/
static Evas_Object*
create_button_view(Evas_Object *parent, const char* text,int x,int y, int w, int h)
{
	Evas_Object *btn, *box;
	char buf[64];
	btn = elm_button_add(parent);


	box = elm_box_add(parent);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_padding_set(box, 0, 5 * elm_config_scale_get());
	evas_object_show(box);

	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", prev_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "prev");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(100), ELM_SCALE_SIZE(100));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	//down
	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", next_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "next");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(100), ELM_SCALE_SIZE(100));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	return box;

}

void
view_control_ppt(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *scroller, *circle_scroller, *layout;
	Evas_Object *box;
	Evas_Object *rect;
	Evas_Object *btn;


	Evas_Object *nf = ad->nf;
	Elm_Object_Item *nf_it;
	Evas_Coord w,h;

	int i;

	char buf[64];

	scroller = elm_scroller_add(ad->nf);
	elm_object_scroll_lock_y_set(scroller,EINA_TRUE);
	evas_object_show(scroller);

	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	box = elm_box_add(scroller);
	elm_box_horizontal_set(box,EINA_TRUE);
	elm_object_content_set(scroller,box);
	evas_object_show(box);

	rect = evas_object_rectangle_add(evas_object_evas_get(box));
	evas_object_geometry_get(ad->nf,NULL,NULL,&w,&h);
	evas_object_size_hint_min_set(rect,(w-ICON_WIDTH),h);
	elm_box_pack_end(box,rect);

	//box

	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", prev_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "prev");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(50), ELM_SCALE_SIZE(50));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);


	/*
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_padding_set(box, 0, 5 * elm_config_scale_get());
	evas_object_show(box);
*/

	//next
	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", show_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "show");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(50), ELM_SCALE_SIZE(50));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", next_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "next");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(50), ELM_SCALE_SIZE(50));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);



	nf_it = elm_naviframe_item_push(nf, "", NULL, NULL, scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);

}





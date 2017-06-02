/*
 *hyunkyung
 */
#include "gearcon_m.h"
#include <stdio.h>
#include <Elementary.h>
#include <dlog.h>

/*
 * 여기에는 그 로터리 핸들 이벤트 처리 XXXX
 * */
#define ICON_WIDTH 80
#define ICON_HEIGHT 80


Evas_Object *entry;
Evas_Object *box;


typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;


static void
prev_btn_clicked_cb(void *data, Evas_Object *obj, void *event_ifo)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"hyunkyung _ prev_button");
}

static void
next_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"hyunkyung _ next_button");
}

static void
play_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"hyunkyung _ show button");
}


static Evas_Object*
create_scroller(Evas_Object *parent)
{
	Evas_Object *scroller = elm_scroller_add(parent);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	elm_object_scroll_lock_y_set(scroller,EINA_TRUE);

	evas_object_show(scroller);

	return scroller;

}

static Evas_Object*
create_button_view(Evas_Object *parent)
{
	Evas_Object *btn, *box;
	char buf[64];
	btn = elm_button_add(parent);


	box = elm_box_add(parent);
	elm_box_horizontal_set(box,EINA_TRUE);

	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_box_padding_set(box, 5, 1 * elm_config_scale_get());

	evas_object_show(box);

	//font size change 	snprintf(buf, sizeof(buf), "<font_size=20><b>next</b></font_size>");


	//prev
	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", prev_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "<font_size=50>prev</font_size>");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(70), ELM_SCALE_SIZE(70));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);


	//slide show start
	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", play_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "<font_size=30><align = center > <br>play</br>stop<br>　</br></align></font_size>");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(70), ELM_SCALE_SIZE(70));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	//next

	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", next_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "<font_size=40>next</font_size>");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(70), ELM_SCALE_SIZE(70));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	return box;

}

void
view_control_player(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *scroller, *circle_scroller, *layout;

	Evas_Object *nf = ad->nf;
	Elm_Object_Item *nf_it;

	scroller = create_scroller(nf);
	layout = create_button_view(scroller);
	elm_object_content_set(scroller, layout);

	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	nf_it = elm_naviframe_item_push(nf, "", NULL, NULL, scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);

}





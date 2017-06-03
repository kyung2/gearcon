/*
 *hyunkyung
 */
#include "gearcon.h"
#include <stdio.h>
#include <Elementary.h>
#include <dlog.h>

#define ICON_WIDTH 80
#define ICON_HEIGHT 80

typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;

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
	Evas_Object *popup;
	Evas_Object *layout;

	char buf[64];

	popup = elm_popup_add(parent);
	elm_object_style_set(popup, "circle");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	layout = elm_layout_add(popup);
	elm_layout_theme_set(layout, "layout", "popup", "content/circle");

	elm_object_part_text_set(layout, "elm.text.title", "Connect");
	//elm_object_part_text_set(layout,"elm.text","<font_size=100>1234</font_size>");

	char * pckey;
	tul_get_time_id(&pckey);
	elm_object_part_text_set(layout,"elm.text", pckey);
	snprintf(buf, sizeof(buf), "next");

	elm_object_content_set(popup, layout);
	evas_object_show(popup);
	tul_connect(pckey,pckey);
	return popup;
}

void
set_pckey(void *data, char * text)
{
	appdata_s *ad = (appdata_s *)data;
	elm_object_part_text_set(ad->layout,"elm.text", text);
}

void
view_connect(void *data)
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

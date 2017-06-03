/*
 *hyunkyung
 */
#include "gearcon.h"


typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;

static void
gl_selected_cb(void *data, Evas_Object *obj, void *event_info)
{
	Elm_Object_Item *it = (Elm_Object_Item *)event_info;
	elm_genlist_item_selected_set(it, EINA_FALSE);
}

static char *
_gl_menu_title_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];

	snprintf(buf, 1023, "%s", "Entry");
	return strdup(buf);
}

static char *
_gl_menu_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];
	item_data *id = (item_data *)data;
	int index = id->index;

	if (!strcmp(part, "elm.text")) {
		snprintf(buf, 1023, "%s", entry_menu_names[index]);
		return strdup(buf);
	}
	return NULL;
}

static void
_gl_menu_del(void *data, Evas_Object *obj)
{
	// FIXME: Unrealized callback can be called after this.
	// Accessing Item_Data can be dangerous on unrealized callback.
	item_data *id = (item_data *)data;
	if (id) free(id);
}

Evas_Object *to_del;
static void response_cb(void *data, Evas_Object *obj, void *event_info)
{
	if (to_del) {
		evas_object_del(to_del);
		to_del = NULL;
	}
	evas_object_del(obj);
}

void maxlength_reached(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup;
	Evas_Object *nf = (Evas_Object *)data;
	appdata_s *ad;
	if (to_del) return;

	ad = (appdata_s *)data;

	popup = elm_popup_add(nf);
	elm_object_style_set(popup, "toast/circle");
	elm_popup_orient_set(popup, ELM_POPUP_ORIENT_BOTTOM);
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_popup_timeout_set(popup, 2.0);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, response_cb, NULL);
	evas_object_smart_callback_add(popup, "block,clicked", response_cb, NULL);
	evas_object_smart_callback_add(popup, "timeout", response_cb, NULL);
	elm_object_part_text_set(popup, "elm.text", "Maximum length reached");

	evas_object_show(popup);
	to_del = popup;
}


static Evas_Object*
create_scroller(Evas_Object *parent)
{
	Evas_Object *scroller = elm_scroller_add(parent);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	return scroller;
}

Eina_Bool
_rotary_handler_pdf_cb(void *data, Evas_Object *obj, Eext_Rotary_Event_Info *ev)
{
	dlog_print(DLOG_DEBUG ,LOG_TAG,"direction %d",ev->direction);
   if (ev->direction == EEXT_ROTARY_DIRECTION_CLOCKWISE)
   {
      dlog_print(DLOG_DEBUG, LOG_TAG, "hello~~ 돌아간다 ~");
   }
   else
   {
      dlog_print(DLOG_DEBUG, LOG_TAG, "반시계반향~ ");
   }

   return EINA_FALSE;
}


static Evas_Object*
create_button_view(Evas_Object *parent)
{
	Evas_Object *btn, *box;
	char buf[64];

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
view_control_pdf(void *data)
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


	   eext_rotary_object_event_callback_add(scroller ,_rotary_handler_pdf_cb,NULL);
	   eext_rotary_object_event_activated_set(scroller, EINA_TRUE);


	nf_it = elm_naviframe_item_push(nf, "", NULL, NULL, scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);

}





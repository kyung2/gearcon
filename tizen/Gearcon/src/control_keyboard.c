/*
 *hyunkyung
 */
#include "gearcon.h"


typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;

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

static void _entry_enter_click(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"enter key clicked!!\n");
}

void
view_control_keyboard(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *scroller, *circle_scroller, *layout;
	Evas_Object *nf = ad->nf;
	Elm_Object_Item *nf_it;
	Evas_Object *entry;
	static Elm_Entry_Filter_Limit_Size limit_filter_data;

	scroller = elm_scroller_add(nf);
	evas_object_size_hint_align_set(scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	layout = elm_layout_add(scroller);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "entry_layout");
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, 0.0);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, 0.0);

	entry = elm_entry_add(layout);
	elm_entry_single_line_set(entry, EINA_TRUE);
	elm_entry_scrollable_set(entry, EINA_TRUE);
	elm_scroller_policy_set(entry, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_smart_callback_add(entry, "maxlength,reached", maxlength_reached, nf);

	limit_filter_data.max_char_count = 0;
	limit_filter_data.max_byte_count = 100;
	elm_entry_markup_filter_append(entry, elm_entry_filter_limit_size, &limit_filter_data);
	elm_object_part_text_set(entry, "elm.guide", "input your text");
	elm_entry_cursor_end_set(entry);
	evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_smart_callback_add(entry, "activated", _entry_enter_click, NULL);

	elm_object_part_content_set(layout, "entry_part", entry);
	elm_object_content_set(scroller, layout);

	elm_naviframe_item_push(nf, _("Single line entry"), NULL, NULL, scroller, "empty");
}





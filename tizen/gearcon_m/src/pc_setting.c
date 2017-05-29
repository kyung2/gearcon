#include "gearcon_m.h"


#define NUM_OF_ITEMS 101
#define NUM_OF_GENLIST_DEMO_NAMES 101
#define NUM_OF_GENLIST_DEMO_LONG_TEXT 7

//함수 여기다가 선언좀 해놓기!

static Evas_Object* create_scroller(Evas_Object *parent);
static Eina_Bool _setting_finished_cb(void *data, Elm_Object_Item *it);



typedef struct _item_data {
	int index;
	Elm_Object_Item *item;
} item_data;


	 // PC CONTROL - > PCSETTING(밝기.배터리,볼륨,와이파이,블투,전원
static char *main_menu_names[] = {
	/*** 1line styles ***/
	"밝기",
	"볼륨",
	"전원",
	/* do not delete below */
	NULL
};
//hyunkyunhg
/*
 * @brief Function will be operated when manipulating setting value is finished
 * @param[in] data The data to be passed to the callback function
 * @param[in] it The item to be popped from naviframe
 */

void
my_A_cb (void *data)
{
	 appdata_s *ad = data;
	   Evas_Object *bg;

	   bg = elm_bg_add(ad->nf);
	   elm_bg_color_set(bg, 66, 162, 206);
	   elm_naviframe_item_push(ad->nf, "Solid Color", NULL, NULL, bg, "empty");

//a페이지 생성코드
}


static void
gl_selected_cb(void *data, Evas_Object *obj, void *event_info)
{
	Elm_Object_Item *it = (Elm_Object_Item *)event_info;
	elm_genlist_item_selected_set(it, EINA_FALSE);
}

/*
 * @brief Function to get string on genlist title item's text part
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] part The name of text part
 * @param[out] char* A string with the characters to use as genlist title item's text part
 */
static char*
_gl_title_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];

	snprintf(buf, 1023, "%s", "Setting");

	return strdup(buf);
}

/*
 * @brief Function to get string on genlist item's text part
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] part The name of text part
 * @param[out] char* A string with the characters to use as genlist item's text part
 */
static char *
_gl_main_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];
	item_data *id = data;
	int index = id->index;

	if (!strcmp(part, "elm.text")) {
		snprintf(buf, 1023, "%s", main_menu_names[index]);
		return strdup(buf);
	}
	return NULL;
}

/*
 * @brief Function will be operated when genlist is deleted.
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 */
static void _gl_del(void *data, Evas_Object *obj)
{
	// FIXME: Unrealized callback can be called after this.
	// Accessing Item_Data can be dangerous on unrealized callback.
	item_data *id = data;
	if (id) free(id);
}

/*
 * @brief Function will be operated when naviframe pop its own item
 * @param[in] data The data to be passed to the callback function
 * @param[in] it The item to be popped from naviframe
 */

static Eina_Bool
_setting_finished_cb(void *data, Elm_Object_Item *it)
{
	appdata_s *ad = data;

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(ad->circle_genlist, EINA_TRUE);
	return EINA_TRUE;
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

/*
 * @brief Function will be operated when button is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	elm_naviframe_item_pop(ad->nf);
}


void
view_PC_Setting(void *data)
{

	appdata_s *ad = (appdata_s *)data;
	Evas_Object *genlist = NULL;
	Evas_Object *naviframe = ad->nf;
	Elm_Object_Item *nf_it = NULL;
	Elm_Genlist_Item_Class *itc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *titc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *pitc = elm_genlist_item_class_new();
	item_data *id = NULL;
	int index = 0;

	/* Create Genlist */
	genlist = elm_genlist_add(naviframe);
	elm_genlist_mode_set(genlist, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(genlist, "selected", NULL, NULL);

	/* Create Circle Genlist */
	ad->circle_genlist = eext_circle_object_genlist_add(genlist, ad->circle_surface);

	/* Set Scroller Policy */
	eext_circle_object_genlist_scroller_policy_set(ad->circle_genlist, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(ad->circle_genlist, EINA_TRUE);

	/* Genlist Item Style */
	itc->item_style = "default";
	itc->func.text_get = _gl_main_text_get;
	itc->func.del = _gl_del;

	/* Genlist Title Item Style */
	titc->item_style = "title";
	titc->func.text_get = _gl_title_text_get;
	titc->func.del = _gl_del;

	/* Genlist Padding Item Style */
	pitc->item_style = "padding";

	/* Title Item Here */
	elm_genlist_item_append(genlist, titc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);

	/* Main Menu Items Here */

	 // PC CONTROL - > PCSETTING(밝기.배터리,볼륨,와이파이,블투,전원
//밝기
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, view_control_brightness, ad);
	//배터리
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, view_control_volume, ad);
	//전원
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, view_pcoff, ad);
	/* Padding Item Here */
	elm_genlist_item_append(genlist, pitc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);

	nf_it = elm_naviframe_item_push(naviframe, NULL, NULL, NULL, genlist, "empty");
	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);

}



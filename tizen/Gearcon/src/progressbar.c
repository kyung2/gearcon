/*
 * Copyright (c) 2014 Samsung Electronics Co., Ltd All Rights Reserved
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 */

#include "gearcon.h"

Ecore_Timer *p_timer = NULL;
Eina_Bool stop_flag = EINA_FALSE;
/*
Evas_Object *
_create_progressbar(appdata_s *ad)
{
	Evas_Object *scroller;
	Evas_Object *circle_scroller;
	Evas_Object *nf = ad->nf;
	Evas_Object *progressbar;
	Evas_Object *layout;

	scroller = elm_scroller_add(nf);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller,ELM_SCROLLER_POLICY_OFF,ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	// processs style
	progressbar = elm_progressbar_add(layout);
	elm_object_style_set(progressbar, "process");
	evas_object_size_hint_align_set(progressbar, EVAS_HINT_FILL, 0.5);
	evas_object_size_hint_weight_set(progressbar, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(progressbar);
	elm_progressbar_pulse(progressbar, EINA_TRUE);
	elm_object_part_content_set(layout, "process", progressbar);

	progressbar = elm_progressbar_add(layout);
	elm_object_style_set(progressbar, "process/small");
	evas_object_size_hint_align_set(progressbar, EVAS_HINT_FILL, 0.5);
	evas_object_size_hint_weight_set(progressbar, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(progressbar);
	elm_progressbar_pulse(progressbar, EINA_TRUE);
	elm_object_part_content_set(layout, "process/small", progressbar);

	elm_object_content_set(scroller, layout);

	return scroller;
}

void progressbar_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *scroller;
	Evas_Object *nf = ad->nf;
	Elm_Object_Item *nf_it;

	scroller = _create_progressbar(ad);

	nf_it = elm_naviframe_item_push(nf, "ProgressBar", NULL, NULL, scroller, "empty");
}*/


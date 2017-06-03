S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20170222.0733
Build-Date: 2017.02.22 07:33:10

Crash Information
Process Name: gearcon
PID: 12915
Date: 2017-06-03 20:14:55+0900
Executable File Path: /opt/usr/apps/org.example.gearcon/bin/gearcon
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb419f201
ebp = 0xbfd5e1f8, esp = 0xbfd5e164
eax = 0x00000000, ebx = 0xb41a2000
ecx = 0x00000000, edx = 0xb419f1a7
eip = 0xb74d9dd6

Memory Information
MemTotal:      123 KB
MemFree:        45 KB
Buffers:        10 KB
Cached:     136388 KB
VmPeak:     156508 KB
VmSize:     127940 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17428 KB
VmRSS:       17428 KB
VmData:      64064 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32816 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 12915 TID = 12915
12915 12922 12923 12924 

Maps Information
b2301000 b2325000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b232a000 b232d000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b232e000 b2330000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnu-i686-1.7.99/module.so
b233d000 b234b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b2b4d000 b2b5c000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3b74000 b3b77000 r-xp /usr/lib/libdri2.so.0.0.0
b3b78000 b3b83000 r-xp /usr/lib/libdrm.so.2.4.0
b3b84000 b3b8d000 r-xp /usr/lib/libtbm.so.1.0.0
b3b8e000 b3b95000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3b96000 b3b9f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3ba0000 b3ba7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3ba8000 b3bb0000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3bb1000 b3bb5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3bb6000 b3bd3000 r-xp /usr/lib/libtts.so
b3bd4000 b3d18000 r-xp /usr/lib/libcairo.so.2.11200.14
b3d1c000 b3d34000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3d35000 b3d3b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3d3c000 b3d59000 r-xp /usr/lib/libnetwork.so.0.0.0
b3d5a000 b3d7d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3d7e000 b3d8e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3d8f000 b3da1000 r-xp /usr/lib/libcapi-network-connection.so.1.0.60
b3da2000 b3da3000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b3da4000 b3da7000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3dac000 b3dae000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b3db1000 b3dbc000 r-xp /lib/libnss_files-2.13.so
b3fbe000 b3fe5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3fe6000 b400b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b400c000 b412d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b413d000 b4173000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4175000 b4178000 r-xp /usr/lib/libiniparser.so.0
b417a000 b4185000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4186000 b418f000 r-xp /usr/lib/libappsvc.so.0.1.0
b4190000 b4193000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4194000 b41a1000 r-xp /opt/usr/apps/org.example.gearcon/bin/gearcon
b41a3000 b41a9000 r-xp /usr/lib/libogg.so.0.7.1
b41aa000 b41d5000 r-xp /usr/lib/libvorbis.so.0.4.3
b41d6000 b42c1000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42cf000 b42d1000 r-xp /usr/lib/libXau.so.6.0.0
b42d2000 b432b000 r-xp /usr/lib/libssl.so.1.0.0
b4330000 b4361000 r-xp /usr/lib/libidn.so.11.5.44
b4362000 b4372000 r-xp /usr/lib/libcares.so.2.1.0
b4373000 b43dc000 r-xp /usr/lib/libsndfile.so.1.0.25
b43e2000 b43ee000 r-xp /usr/lib/libsensord-shared.so
b43ef000 b4415000 r-xp /lib/libexpat.so.1.5.2
b4417000 b443e000 r-xp /usr/lib/libpng12.so.0.50.0
b443f000 b445f000 r-xp /usr/lib/libxcb.so.1.1.0
b4460000 b44cf000 r-xp /usr/lib/libcurl.so.4.3.0
b44d1000 b44dc000 r-xp /usr/lib/libethumb.so.1.7.99
b5d59000 b5e31000 r-xp /usr/lib/libstdc++.so.6.0.16
b5e3d000 b5e40000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e41000 b5e57000 r-xp /usr/lib/libremix.so.0.0.0
b5e58000 b5e5a000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e5b000 b5e87000 r-xp /usr/lib/liblua-5.1.so
b5e88000 b5e92000 r-xp /usr/lib/libembryo.so.1.7.99
b5e93000 b5ed9000 r-xp /usr/lib/libjpeg.so.8.0.2
b5eea000 b5f19000 r-xp /usr/lib/libsensor.so.1.9.0
b5f1a000 b5f9c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5fa1000 b5fd5000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5fd7000 b6032000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6034000 b604a000 r-xp /usr/lib/libfribidi.so.0.3.1
b604b000 b60d7000 r-xp /usr/lib/libfreetype.so.6.11.3
b60db000 b60de000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b60df000 b60e5000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b60e6000 b60ec000 r-xp /usr/lib/libecore_fb.so.1.7.99
b60ee000 b60ff000 r-xp /usr/lib/libXext.so.6.4.0
b6100000 b6234000 r-xp /usr/lib/libX11.so.6.3.0
b6238000 b623d000 r-xp /usr/lib/libXtst.so.6.1.0
b623e000 b6246000 r-xp /usr/lib/libXrender.so.1.3.0
b6247000 b6250000 r-xp /usr/lib/libXrandr.so.2.2.0
b6251000 b6253000 r-xp /usr/lib/libXinerama.so.1.0.0
b6254000 b6262000 r-xp /usr/lib/libXi.so.6.1.0
b6263000 b6267000 r-xp /usr/lib/libXfixes.so.3.1.0
b6268000 b626a000 r-xp /usr/lib/libXgesture.so.7.0.0
b626b000 b626d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b626e000 b6270000 r-xp /usr/lib/libXdamage.so.1.1.0
b6271000 b627a000 r-xp /usr/lib/libXcursor.so.1.0.2
b627b000 b62a6000 r-xp /usr/lib/libecore_con.so.1.7.99
b62a8000 b62b0000 r-xp /usr/lib/libecore_imf.so.1.7.99
b62b1000 b62bc000 r-xp /usr/lib/libethumb_client.so.1.7.99
b62bd000 b62c3000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b62c4000 b62e5000 r-xp /usr/lib/libefreet.so.1.7.99
b62e7000 b62f3000 r-xp /usr/lib/libedbus.so.1.7.99
b62f4000 b6483000 r-xp /usr/lib/libicuuc.so.57.1
b6492000 b670e000 r-xp /usr/lib/libicui18n.so.57.1
b6717000 b67b5000 r-xp /usr/lib/libedje.so.1.7.99
b67b7000 b67c8000 r-xp /usr/lib/libecore_input.so.1.7.99
b67c9000 b67d0000 r-xp /usr/lib/libecore_file.so.1.7.99
b67d1000 b67f7000 r-xp /usr/lib/libeet.so.1.7.99
b6800000 b692a000 r-xp /usr/lib/libevas.so.1.7.99
b6948000 b697c000 r-xp /usr/lib/libecore_evas.so.1.7.99
b697e000 b69c2000 r-xp /usr/lib/libecore_x.so.1.7.99
b69c4000 b6bbf000 r-xp /usr/lib/libelementary.so.1.7.99
b6bce000 b6bd0000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b6bd1000 b6bd7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6bd8000 b6bdc000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6be1000 b6be2000 r-xp /usr/lib/libjournal.so.0.1.0
b6be3000 b6d2b000 r-xp /usr/lib/libxml2.so.2.7.8
b6d31000 b6d44000 r-xp /lib/libresolv-2.13.so
b6d48000 b6d65000 r-xp /lib/libz.so.1.2.5
b6d66000 b6d69000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d6b000 b6d70000 r-xp /usr/lib/libffi.so.5.0.10
b6d71000 b6d72000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d73000 b6d77000 r-xp /lib/libattr.so.1.1.0
b6d78000 b6f8b000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fa6000 b6fc7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fc9000 b6ff1000 r-xp /lib/libm-2.13.so
b6ff3000 b704e000 r-xp /usr/lib/libeina.so.1.7.99
b7050000 b705b000 r-xp /usr/lib/libvconf.so.0.2.45
b705c000 b705f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7060000 b70ae000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70b0000 b7211000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7215000 b721c000 r-xp /lib/librt-2.13.so
b721e000 b7225000 r-xp /usr/lib/libcapi-base-common.so.0.1.10
b7227000 b7241000 r-xp /lib/libgcc_s-4.6.4.so.1
b7242000 b724a000 r-xp /lib/libcrypt-2.13.so
b7274000 b7278000 r-xp /lib/libcap.so.2.21
b7279000 b727b000 r-xp /usr/lib/libiri.so
b727c000 b72a8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72a9000 b72c9000 r-xp /usr/lib/libecore.so.1.7.99
b72d8000 b72e1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72e2000 b7405000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7407000 b741a000 r-xp /usr/lib/libail.so.0.1.0
b741b000 b7440000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7441000 b744b000 r-xp /lib/libunwind.so.8.0.1
b7455000 b75d5000 r-xp /lib/libc-2.13.so
b75dc000 b7626000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7628000 b762d000 r-xp /usr/lib/libbundle.so.0.1.22
b762e000 b7631000 r-xp /lib/libdl-2.13.so
b7633000 b764a000 r-xp /lib/libpthread-2.13.so
b764e000 b7651000 r-xp /usr/lib/libdlog.so.0.0.0
b7652000 b7654000 r-xp /usr/lib/libttrace.so.1.1
b7655000 b765a000 r-xp /usr/lib/libsmack.so.1.0.0
b765b000 b7703000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7706000 b7720000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7721000 b7731000 r-xp /usr/lib/libaul.so.0.1.0
b7734000 b773a000 r-xp /usr/lib/libappcore-common.so.1.1
b773b000 b7740000 r-xp /usr/lib/libappcore-efl.so.1.1
b7742000 b7747000 r-xp /usr/lib/libsys-assert.so
b774a000 b774b000 r-xp [vdso]
b774b000 b7769000 r-xp /lib/ld-2.13.so
b776b000 b7772000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:12915)
Call Stack Count: 19
 0: (0xb74d9dd6) [/lib/libc.so.6] + 0x84dd6
 1: app_control + 0x44 (0xb419b2c4) [/opt/usr/apps/org.example.gearcon/bin/gearcon] + 0x72c4
 2: (0xb6bd9d0d) [/usr/lib/libcapi-appfw-application.so.0] + 0x1d0d
 3: (0xb773d1a9) [/usr/lib/libappcore-efl.so.1] + 0x21a9
 4: (0xb7735d7a) [/usr/lib/libappcore-common.so.1] + 0x1d7a
 5: (0xb7725679) [/usr/lib/libaul.so.0] + 0x4679
 6: (0xb7726722) [/usr/lib/libaul.so.0] + 0x5722
 7: (0xb73258a1) [/usr/lib/libglib-2.0.so.0] + 0x438a1
 8: g_main_context_dispatch + 0x133 (0xb7327e33) [/usr/lib/libglib-2.0.so.0] + 0x45e33
 9: (0xb72bdd40) [/usr/lib/libecore.so.1] + 0x14d40
10: (0xb72b696f) [/usr/lib/libecore.so.1] + 0xd96f
11: (0xb72b7579) [/usr/lib/libecore.so.1] + 0xe579
12: ecore_main_loop_begin + 0x3f (0xb72b79cf) [/usr/lib/libecore.so.1] + 0xe9cf
13: elm_run + 0x17 (0xb6acd0f7) [/usr/lib/libelementary.so.1] + 0x1090f7
14: appcore_efl_main + 0x418 (0xb773dfe8) [/usr/lib/libappcore-efl.so.1] + 0x2fe8
15: ui_app_main + 0x130 (0xb6bda4c0) [/usr/lib/libcapi-appfw-application.so.0] + 0x24c0
16: main + 0x2fb (0xb419b16b) [/opt/usr/apps/org.example.gearcon/bin/gearcon] + 0x716b
17: maxlength_reached + 0x119 (0xb776e659) [/opt/usr/apps/org.example.gearcon/bin/gearcon] + 0xb776e659
18: __libc_start_main + 0xf3 (0xb746e1a3) [/lib/libc.so.6] + 0x191a3
End of Call Stack

Package Information
Package Name: org.example.gearcon
Package ID : org.example.gearcon
Version: 1.0.0
Package Type: rpm
App Name: gearcon
App ID: org.example.gearcon
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.gearcon/bin/gearcon' and package_app_info.app_disable IN ('false','False')
06-03 20:14:34.826+0900 I/CRASH_POPUP(12799): crash.c: load_crash_process_popup(117) > Popup content: gearcon has closed unexpectedly.
06-03 20:14:34.836+0900 E/EFL     (12799): eina_module<12799> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-03 20:14:34.846+0900 D/IMMODULE(10883): isf_imf_context.cpp: isf_imf_context_focus_out(1540) > ctx : 0xb9277cc0
06-03 20:14:34.846+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: check_focus_out_by_popup_win(6153) > win type : 12
06-03 20:14:34.846+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(435) > win type : 12
06-03 20:14:34.846+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > client window : 0x1c00002, focus window : 0x1e00006
06-03 20:14:34.846+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _client_window_focus_out_cb(402) > ctx : 0xb9277cc0, client_window : 0x1c00002, focus-out win : 0x1c00002, focus-in win : 0x1e00006
06-03 20:14:34.846+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(435) > win type : 12
06-03 20:14:34.846+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > client window : 0x1c00002, focus window : 0x1e00006
06-03 20:14:34.866+0900 D/LAUNCH  (12799): appcore-efl.c: __do_app(506) > [crash-popup:Application:reset:done]
06-03 20:14:34.866+0900 D/AUL_PAD ( 2297): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
06-03 20:14:34.866+0900 D/AUL_PAD ( 2297): sigchild.h: __send_app_launch_signal(112) > send launch signal done
06-03 20:14:34.866+0900 D/AUL_PAD ( 2297): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
06-03 20:14:34.866+0900 D/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-03 20:14:34.866+0900 E/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(264) > access
06-03 20:14:34.866+0900 D/RESOURCED( 2483): proc-noti.c: recv_str(87) > [recv_str,87] str is null
06-03 20:14:34.866+0900 D/RESOURCED( 2483): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2277
06-03 20:14:34.866+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 12799, type 4 
06-03 20:14:34.866+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 12799
06-03 20:14:34.866+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
06-03 20:14:34.866+0900 E/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 351
06-03 20:14:34.866+0900 D/RESOURCED( 2483): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
06-03 20:14:34.866+0900 D/AUL     (12798): launch.c: app_request_to_launchpad(301) > launch request result : 12799
06-03 20:14:34.866+0900 I/APP_CORE(12799): appcore-efl.c: __do_app(512) > Legacy lifecycle: 0
06-03 20:14:34.876+0900 E/AUL_AMD ( 2277): amd_status.c: __lcd_status_cb(680) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
06-03 20:14:34.876+0900 D/STARTER ( 2368): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
06-03 20:14:34.876+0900 W/STARTER ( 2368): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
06-03 20:14:34.876+0900 I/APP_CORE(12799): appcore-efl.c: __do_app(514) > [APP 12799] Initial Launching, call the resume_cb
06-03 20:14:34.876+0900 D/APP_CORE(12799): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
06-03 20:14:34.876+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: on_changed_receive(1293) > org.tizen.system.deviced.display - LCDOn
06-03 20:14:34.876+0900 D/APP_CORE(12799): appcore-efl.c: __show_cb(839) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00006
06-03 20:14:34.876+0900 D/APP_CORE(12799): appcore-efl.c: __add_win(685) > [EVENT_TEST][EVENT] __add_win WIN:1e00006
06-03 20:14:34.876+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-03 20:14:34.876+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-03 20:14:34.876+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: preference_get_int(1063) > preference_get_int(2384) : key(clock_font_color) error
06-03 20:14:34.876+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-03 20:14:34.876+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-03 20:14:34.876+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: preference_get_int(1063) > preference_get_int(2384) : key(showdate) error
06-03 20:14:34.876+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: clock_view_set_info_time(877) > show_date:1
06-03 20:14:34.876+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Sat, 3 Jun][1496488474]
06-03 20:14:34.876+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: clock_view_set_info_time(885) > 
06-03 20:14:34.876+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[pm][1496488474]
06-03 20:14:34.876+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[8:14][1496488474]
06-03 20:14:34.876+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: clock_view_set_info_time(899) > utc_time=8:14, utc_ampm=[2]pm
06-03 20:14:34.876+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>8:14<font_size=24><font=Tizen:style=Bold>pm</font></font_size></color>
06-03 20:14:34.876+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain reset_input_context 713293853
06-03 20:14:34.876+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain focus_out 713293853
06-03 20:14:34.906+0900 D/RESOURCED( 2483): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 12799, type = 0
06-03 20:14:34.906+0900 D/AUL_AMD ( 2277): amd_launch.c: __e17_status_handler(1939) > pid(12799) status(3)
06-03 20:14:34.906+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 12799
06-03 20:14:34.906+0900 I/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 12799, oom : 200
06-03 20:14:34.906+0900 E/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
06-03 20:14:34.906+0900 E/RESOURCED( 2483): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (12799) didn't have any process list
06-03 20:14:34.906+0900 D/RESOURCED( 2483): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 12799, appname = (null)
06-03 20:14:34.906+0900 D/RESOURCED( 2483): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12799
06-03 20:14:34.916+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: _device_state_changed_cb(1131) > DISPLAY STATE [0]
06-03 20:14:34.916+0900 D/DATA_PROVIDER_MASTER( 2420): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-03 20:14:34.916+0900 D/NET_NFC_MANAGER( 2414): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
06-03 20:14:34.916+0900 D/NET_NFC_MANAGER( 2414): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
06-03 20:14:34.916+0900 D/NET_NFC_MANAGER( 2414): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_configure_discovery(2040) > [0;36m BEGIN >>>>[0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_configure_discovery(2063) > [0;36m Create Thread[0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_init(1863) > [0;36m BEGIN >>>>[0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_init(1865) > [0;36m start stack init [0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: _net_nfc_emul_controller_start_thread(1828) > [0;36m BEGIN >>>>[0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: _net_nfc_emul_controller_start_thread(1835) > [0;36m END >>>>[0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: emul_ReaderThread(1635) > [0;36m emul_ReaderThread START >>>>[0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_init(1880) > [0;36m Stack init finished[0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: emul_ReaderThread(1646) > file path : /dev/nfc0
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_init(1885) > [0;36m END >>>>[0;m
06-03 20:14:34.916+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_configure_discovery(2068) > [0;36m END >>>>[0;m
06-03 20:14:34.916+0900 D/NET_NFC_MANAGER( 2414): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
06-03 20:14:34.926+0900 D/APP_CORE(10883): appcore-rotation.c: __changed_cb(123) > [APP 10883] Rotation: 1 -> 1
06-03 20:14:34.936+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: emul_ReaderThread(1687) > [0;36m epoll wait >>>>[0;m
06-03 20:14:34.936+0900 W/W_HOME  ( 2375): dbus.c: _dbus_message_recv_cb(178) > LCD on
06-03 20:14:34.936+0900 W/W_HOME  ( 2375): main.c: _lcd_on_cb(951) > LCD: off->on
06-03 20:14:34.936+0900 D/W_HOME  ( 2375): clock_event.c: _display_state_cb(194) > LCD: off->on
06-03 20:14:34.936+0900 D/W_HOME  ( 2375): clock_view.c: clock_view_event_handler(843) > event:40000 received
06-03 20:14:34.936+0900 D/W_HOME  ( 2375): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
06-03 20:14:34.956+0900 D/APP_CORE(12799): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1e00006 fully_obscured 0
06-03 20:14:34.956+0900 D/APP_CORE(12799): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active -1
06-03 20:14:34.956+0900 D/APP_CORE(12799): appcore-efl.c: __visibility_cb(900) >  Go to Resume state
06-03 20:14:34.956+0900 D/APP_CORE(12799): appcore-efl.c: __do_app(471) > [APP 12799] Event: RESUME State: RUNNING
06-03 20:14:34.956+0900 D/LAUNCH  (12799): appcore-efl.c: __do_app(566) > [crash-popup:Application:resume:start]
06-03 20:14:34.956+0900 D/LAUNCH  (12799): appcore-efl.c: __do_app(580) > [crash-popup:Application:resume:done]
06-03 20:14:34.956+0900 D/LAUNCH  (12799): appcore-efl.c: __do_app(582) > [crash-popup:Application:Launching:done]
06-03 20:14:34.956+0900 D/APP_CORE(12799): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
06-03 20:14:34.956+0900 E/APP_CORE(12799): appcore-efl.c: __trm_app_info_send_socket(234) > access
06-03 20:14:35.016+0900 D/APP_CORE(12799): appcore.c: __prt_ltime(183) > [APP 12799] first idle after reset: 266 msec
06-03 20:14:35.866+0900 D/AUL_AMD ( 2277): amd_request.c: __add_history_handler(255) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
06-03 20:14:35.866+0900 D/RUA     ( 2277): rua.c: rua_add_history(179) > rua_add_history start
06-03 20:14:35.876+0900 D/RUA     ( 2277): rua.c: rua_add_history(247) > rua_add_history ok
06-03 20:14:42.676+0900 I/GESTURE ( 2239): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-03 20:14:42.726+0900 D/EFL     (12799): ecore_x<12799> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=28918678 button=1
06-03 20:14:42.816+0900 D/EFL     (12799): ecore_x<12799> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=28918828 button=1
06-03 20:14:42.816+0900 E/EFL     (12799): eina_module<12799> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-03 20:14:42.826+0900 D/AUL     (12799): app_sock.c: __app_send_raw_with_noreply(370) > pid(-2) : cmd(22)
06-03 20:14:42.826+0900 D/AUL_AMD ( 2277): amd_request.c: __request_handler(506) > __request_handler: 22
06-03 20:14:42.826+0900 D/APP_CORE(12799): appcore-efl.c: __after_loop(1081) > [APP 12799] PAUSE before termination
06-03 20:14:42.826+0900 D/IMMODULE(10883): isf_imf_context.cpp: isf_imf_context_focus_in(1486) > ctx : 0xb9277cc0. set autocapital type : 2
06-03 20:14:42.826+0900 D/IMMODULE(10883): isf_imf_context.cpp: isf_imf_context_focus_in(1501) > ctx : 0xb9277cc0. on demand : 0
06-03 20:14:42.826+0900 D/ISE_WEB_HELPER_AGENT( 2385): ise.cpp: ise_focus_in(372) > ic : 2a84001d , 0 , g_ic : 2a84001d , 0, g_focused_ic : 0 , 1
06-03 20:14:42.826+0900 D/ISE_WEB_HELPER_AGENT( 2385): common.cpp: set_keyboard_ise_by_uuid(577) > Calling helper_agent.set_keyboard_ise_by_uuid() : 
06-03 20:14:42.836+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_return_key_disabled_set(838) > [SECURE_LOG] Return key disabled : 0
06-03 20:14:42.836+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_get_ise_state(5345) > state = 0
06-03 20:14:42.836+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(916) >     state:0
06-03 20:14:42.836+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(600) > already show
06-03 20:14:42.836+0900 D/IMMODULE(10883): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1634) > ctx : 0xb9277cc0, cursor pos : 5
06-03 20:14:42.836+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_caps_mode_set(721) > [SECURE_LOG] ctx : 0xb9277cc0, mode : 0
06-03 20:14:42.836+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain focus_in 713293853
06-03 20:14:42.836+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain set_return_key_type default
06-03 20:14:42.856+0900 I/AUL_PAD ( 2297): sigchild.h: __launchpad_sig_child(142) > dead_pid = 12799 pgid = 12799
06-03 20:14:42.856+0900 I/AUL_PAD ( 2297): sigchild.h: __sigchild_action(123) > dead_pid(12799)
06-03 20:14:42.856+0900 D/AUL_PAD ( 2297): sigchild.h: __send_app_dead_signal(81) > send dead signal done
06-03 20:14:42.856+0900 I/AUL_PAD ( 2297): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-03 20:14:42.856+0900 I/AUL_PAD ( 2297): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-03 20:14:42.856+0900 I/AUL_AMD ( 2277): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12799
06-03 20:14:42.856+0900 D/AUL_AMD ( 2277): amd_key.c: _unregister_key_event(161) > ===key stack===
06-03 20:14:42.856+0900 D/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-03 20:14:42.856+0900 D/STARTER ( 2368): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 12799)
06-03 20:14:42.856+0900 E/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(264) > access
06-03 20:14:42.886+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain update_cursor_position 713293853 5
06-03 20:14:42.926+0900 D/W_HOME  ( 2375): main.c: _dead_cb(542) > PID(12799) is dead
06-03 20:14:42.926+0900 E/W_HOME  ( 2375): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
06-03 20:14:44.826+0900 D/AUL_AMD ( 2277): amd_status.c: __app_terminate_timer_cb(113) > pid(12799)
06-03 20:14:44.826+0900 D/AUL_AMD ( 2277): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
06-03 20:14:44.896+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_get_ise_state(5345) > state = 0
06-03 20:14:44.896+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(916) >     state:0
06-03 20:14:44.896+0900 D/IMMODULE(10883): isf_imf_context.cpp: _key_down_cb(571) > XF86Stop key is pressed.
06-03 20:14:45.026+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_get_ise_state(5345) > state = 0
06-03 20:14:45.026+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(916) >     state:0
06-03 20:14:45.026+0900 D/IMMODULE(10883): isf_imf_context.cpp: _key_up_cb(595) > XF86Stop key is released.
06-03 20:14:45.026+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _send_input_panel_hide_request(328) > [SECURE_LOG] Send input panel hide request
06-03 20:14:45.026+0900 D/ISF_UTILITY( 2374): scim_utility.cpp: isf_save_log(1439) > time:1496488485  pid:2374  scim_panel_agent.cpp  hide_ise_panel  prepare to hide ISE, 30 30
06-03 20:14:45.026+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_hide_ise(5271) > slot_hide_ise ()
06-03 20:14:45.026+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: hide_ise(3804) > send request to hide helper
06-03 20:14:45.026+0900 D/ISF_UTILITY( 2374): scim_utility.cpp: isf_save_log(1439) > time:1496488485  pid:2374  scim_panel_agent.cpp  hide_helper  Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:45.026+0900 D/ISF_UTILITY( 2385): scim_utility.cpp: isf_save_log(1439) > time:1496488485  pid:2385  scim_helper.cpp  filter_event  Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:45.026+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_client_message_cb(5939) > _ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_OFF_PREPARE_REQUEST
06-03 20:14:45.026+0900 W/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x1c00002 FAILED!
06-03 20:14:45.036+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: get_ise_geometry(954) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 360 0 0
06-03 20:14:45.036+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1007) > KEYBOARD_GEOMETRY_SET : 0 360 0 0
06-03 20:14:45.036+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _event_callback_call(253) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb9277cc0
06-03 20:14:45.036+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _prop_change(158) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
06-03 20:14:45.036+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _prop_change(165) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 360, w : 0, h : 0
06-03 20:14:45.036+0900 E/EFL     (10883): edje<10883> edje_util.c:3592 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 20:14:45.036+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain reset_input_context 713293853
06-03 20:14:45.036+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain hide 713293853
06-03 20:14:45.046+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _render_post_cb(87) > [_render_post_cb], conformant_reset_done = 1
06-03 20:14:45.046+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_send_will_hide_ack(976) > conformant_reset_done=1, received_will_hide_event=0
06-03 20:14:45.046+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _event_callback_call(228) > [SECURE_LOG] [input panel has been hidden] ctx : 0xb9277cc0
06-03 20:14:45.046+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _process_ise_panel_hided(1065) > received_will_hide_event = 1
06-03 20:14:45.046+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_send_will_hide_ack(970) > Send will hide ack, conformant_reset_done = 0, received_will_hide_event = 0
06-03 20:14:45.046+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_will_hide_ack(5286) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (58, 1200002)
06-03 20:14:45.046+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_will_hide_ack(5288) > calling ui_candidate_hide (true, false)
06-03 20:14:45.106+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5792) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x1200002, atom : 463
06-03 20:14:45.106+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5848) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
06-03 20:14:45.106+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5865) > calling ui_candidate_hide (true, false)
06-03 20:14:45.106+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5792) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x1200002, atom : 463
06-03 20:14:45.106+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5848) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
06-03 20:14:45.106+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5865) > calling ui_candidate_hide (true, false)
06-03 20:14:47.526+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_get_ise_state(5345) > state = 1
06-03 20:14:47.536+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(916) >     state:1
06-03 20:14:47.676+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_get_ise_state(5345) > state = 1
06-03 20:14:47.676+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(916) >     state:1
06-03 20:14:47.686+0900 D/IMMODULE(10883): isf_imf_context.cpp: isf_imf_context_focus_out(1540) > ctx : 0xb9277cc0
06-03 20:14:47.686+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(435) > win type : 8
06-03 20:14:47.686+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(677) > [SECURE_LOG] ctx : 0xb9277cc0
06-03 20:14:47.726+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain reset_input_context 713293853
06-03 20:14:47.726+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain focus_out 713293853
06-03 20:14:47.756+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _send_input_panel_hide_request(328) > [SECURE_LOG] Send input panel hide request
06-03 20:14:47.756+0900 D/ISF_UTILITY( 2374): scim_utility.cpp: isf_save_log(1439) > time:1496488487  pid:2374  scim_panel_agent.cpp  hide_ise_panel  prepare to hide ISE, 30 30
06-03 20:14:47.756+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_hide_ise(5271) > slot_hide_ise ()
06-03 20:14:47.756+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: hide_ise(3804) > send request to hide helper
06-03 20:14:47.756+0900 D/ISF_UTILITY( 2374): scim_utility.cpp: isf_save_log(1439) > time:1496488487  pid:2374  scim_panel_agent.cpp  hide_helper  Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:47.756+0900 D/ISF_UTILITY( 2385): scim_utility.cpp: isf_save_log(1439) > time:1496488487  pid:2385  scim_helper.cpp  filter_event  Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:47.786+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain hide 713293853
06-03 20:14:48.216+0900 D/IMMODULE(10883): isf_imf_context.cpp: isf_imf_context_del(1275) > ctx : 0xb9277cc0
06-03 20:14:48.216+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_get_ise_state(5345) > state = 1
06-03 20:14:48.216+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(916) >     state:1
06-03 20:14:49.126+0900 E/efl-extension(10883): efl_extension_rotary.c: _object_deleted_cb(588) > In: data: 0xb8fb0ea0, obj: 0xb8fb0ea0
06-03 20:14:49.126+0900 I/efl-extension(10883): efl_extension_rotary.c: _object_deleted_cb(617) > done
06-03 20:14:49.136+0900 E/efl-extension(10883): efl_extension_rotary.c: _activated_obj_del_cb(623) > _activated_obj_del_cb : 0xb9107a98
06-03 20:14:49.136+0900 E/efl-extension(10883): efl_extension_rotary.c: _object_deleted_cb(588) > In: data: 0xb9107a98, obj: 0xb9107a98
06-03 20:14:49.136+0900 I/efl-extension(10883): efl_extension_rotary.c: _object_deleted_cb(617) > done
06-03 20:14:49.136+0900 I/efl-extension(10883): efl_extension_rotary.c: eext_rotary_object_event_callback_del(251) > In
06-03 20:14:49.136+0900 E/efl-extension(10883): efl_extension_rotary.c: eext_rotary_object_event_callback_del(256) > callback del 0xb8fb0ea0, elm_genlist, func : 0xb3d6a4d0
06-03 20:14:49.136+0900 I/efl-extension(10883): efl_extension_rotary.c: eext_rotary_object_event_callback_del(289) > done
06-03 20:14:50.386+0900 I/CAPI_APPFW_APPLICATION(10883): app_main.c: app_efl_exit(138) > app_efl_exit
06-03 20:14:50.386+0900 D/AUL     (10883): app_sock.c: __app_send_raw_with_noreply(370) > pid(-2) : cmd(22)
06-03 20:14:50.386+0900 D/AUL_AMD ( 2277): amd_request.c: __request_handler(506) > __request_handler: 22
06-03 20:14:50.386+0900 I/CAPI_APPFW_APPLICATION(10883): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
06-03 20:14:50.386+0900 D/AUL_AMD ( 2277): amd_launch.c: __e17_status_handler(1939) > pid(2375) status(3)
06-03 20:14:50.386+0900 D/RESOURCED( 2483): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2375, type = 0
06-03 20:14:50.386+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2375
06-03 20:14:50.386+0900 D/RESOURCED( 2483): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2375, appname = (null)
06-03 20:14:50.386+0900 D/RESOURCED( 2483): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2375
06-03 20:14:50.396+0900 E/efl-extension(10883): efl_extension_rotary.c: _object_deleted_cb(588) > In: data: 0xb8f9dc30, obj: 0xb8f9dc30
06-03 20:14:50.396+0900 I/efl-extension(10883): efl_extension_rotary.c: _object_deleted_cb(617) > done
06-03 20:14:50.396+0900 E/efl-extension(10883): efl_extension_rotary.c: _object_deleted_cb(588) > In: data: 0xb8fa3e78, obj: 0xb8fa3e78
06-03 20:14:50.396+0900 I/efl-extension(10883): efl_extension_rotary.c: _remove_ecore_handlers(570) > In
06-03 20:14:50.396+0900 I/efl-extension(10883): efl_extension_rotary.c: _remove_ecore_handlers(575) > removed _motion_handler
06-03 20:14:50.396+0900 I/efl-extension(10883): efl_extension_rotary.c: _remove_ecore_handlers(581) > removed _rotate_handler
06-03 20:14:50.396+0900 I/efl-extension(10883): efl_extension_rotary.c: _object_deleted_cb(617) > done
06-03 20:14:50.396+0900 I/efl-extension(10883): efl_extension_rotary.c: eext_rotary_object_event_callback_del(251) > In
06-03 20:14:50.396+0900 E/efl-extension(10883): efl_extension_rotary.c: eext_rotary_object_event_callback_del(256) > callback del 0xb8f9dc30, elm_genlist, func : 0xb3d6a4d0
06-03 20:14:50.396+0900 I/efl-extension(10883): efl_extension_rotary.c: eext_rotary_object_event_callback_del(289) > done
06-03 20:14:50.396+0900 D/IMMODULE(10883): isf_imf_context.cpp: isf_imf_context_shutdown(1150) > immodule shutdown
06-03 20:14:50.406+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_input_panel_shutdown(517) > No hide timer
06-03 20:14:50.406+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_input_panel_shutdown(521) > [SECURE_LOG] candidate_conformant_reset_done = 1
06-03 20:14:50.406+0900 D/IMMODULE(10883): isf_imf_context.cpp: finalize(3454) > Finalizing Ecore ISF IMModule...
06-03 20:14:50.406+0900 I/efl-extension(10883): efl_extension.c: eext_mod_shutdown(45) > Shutdown
06-03 20:14:50.416+0900 I/AUL_PAD ( 2297): sigchild.h: __launchpad_sig_child(142) > dead_pid = 10883 pgid = 10883
06-03 20:14:50.416+0900 I/AUL_PAD ( 2297): sigchild.h: __sigchild_action(123) > dead_pid(10883)
06-03 20:14:50.416+0900 D/AUL_PAD ( 2297): sigchild.h: __send_app_dead_signal(81) > send dead signal done
06-03 20:14:50.416+0900 I/AUL_PAD ( 2297): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-03 20:14:50.416+0900 I/AUL_PAD ( 2297): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-03 20:14:50.416+0900 I/AUL_AMD ( 2277): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10883
06-03 20:14:50.416+0900 D/AUL_AMD ( 2277): amd_key.c: _unregister_key_event(161) > ===key stack===
06-03 20:14:50.416+0900 D/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-03 20:14:50.416+0900 E/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(264) > access
06-03 20:14:50.416+0900 D/STARTER ( 2368): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 10883)
06-03 20:14:50.486+0900 E/W_HOME  ( 2375): main.c: _window_focus_in_cb(851) > win[23068675], ev->win[23068679]
06-03 20:14:50.486+0900 D/APPS    ( 2375): apps_main.c: _window_focus_in_cb(288) >  focus in
06-03 20:14:50.486+0900 E/W_HOME  ( 2375): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
06-03 20:14:50.486+0900 D/APPS    ( 2375): apps_main.c: apps_main_resume(693) >  Resume starts
06-03 20:14:50.486+0900 D/APPS    ( 2375): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
06-03 20:14:50.486+0900 E/efl-extension( 2375): efl_extension_rotary.c: eext_rotary_object_event_activated_set(299) > eext_rotary_object_event_activated_set : 0xb916cc90, elm_scroller, _activated_obj : 0xb916cc90, activated : 1
06-03 20:14:50.486+0900 D/APP_CORE( 2375): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1600007 fully_obscured 0
06-03 20:14:50.486+0900 D/APP_CORE( 2375): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active 0
06-03 20:14:50.486+0900 D/APP_CORE( 2375): appcore-efl.c: __visibility_cb(900) >  Go to Resume state
06-03 20:14:50.486+0900 D/APP_CORE( 2375): appcore-efl.c: __do_app(471) > [APP 2375] Event: RESUME State: PAUSED
06-03 20:14:50.486+0900 D/LAUNCH  ( 2375): appcore-efl.c: __do_app(566) > [w-home:Application:resume:start]
06-03 20:14:50.486+0900 D/APP_CORE( 2375): appcore-efl.c: __do_app(568) > [APP 2375] RESUME
06-03 20:14:50.486+0900 I/CAPI_APPFW_APPLICATION( 2375): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-03 20:14:50.486+0900 D/W_HOME  ( 2375): main.c: _resume_cb(564) > Resumed
06-03 20:14:50.486+0900 D/APPS    ( 2375): apps_main.c: apps_main_is_visible(757) >  bShow:[1]
06-03 20:14:50.486+0900 E/W_HOME  ( 2375): main.c: _resume_cb(576) > Apps is showing
06-03 20:14:50.486+0900 D/LAUNCH  ( 2375): appcore-efl.c: __do_app(580) > [w-home:Application:resume:done]
06-03 20:14:50.486+0900 D/LAUNCH  ( 2375): appcore-efl.c: __do_app(582) > [w-home:Application:Launching:done]
06-03 20:14:50.486+0900 D/APP_CORE( 2375): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
06-03 20:14:50.486+0900 E/APP_CORE( 2375): appcore-efl.c: __trm_app_info_send_socket(234) > access
06-03 20:14:50.486+0900 D/W_HOME  ( 2375): main.c: _dead_cb(542) > PID(10883) is dead
06-03 20:14:50.486+0900 E/W_HOME  ( 2375): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
06-03 20:14:52.386+0900 D/AUL_AMD ( 2277): amd_status.c: __app_terminate_timer_cb(113) > pid(10883)
06-03 20:14:52.386+0900 D/AUL_AMD ( 2277): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
06-03 20:14:54.396+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: main(1436) > server start
06-03 20:14:54.396+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: main(1505) > Main loop is created.
06-03 20:14:54.396+0900 D/PKGMGR  (12863): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(144) > called
06-03 20:14:54.396+0900 D/PKGMGR  (12863): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(155) > done
06-03 20:14:54.396+0900 D/PKGMGR  (12863): comm_pkg_mgr_server.c: pkg_mgr_object_init(93) > called
06-03 20:14:54.406+0900 D/PKGMGR  (12863): comm_pkg_mgr_server.c: pkg_mgr_object_init(130) > RequestName returns: 1
06-03 20:14:54.406+0900 D/PKGMGR  (12863): comm_pkg_mgr_server.c: pkg_mgr_object_init(135) > Ready to serve requests
06-03 20:14:54.416+0900 D/PKGMGR  (12863): comm_pkg_mgr_server.c: pkg_mgr_object_init(139) > done
06-03 20:14:54.416+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: main(1510) > pkg_mgr object is created, and request callback is registered.
06-03 20:14:54.426+0900 D/PKGMGR  (12863): comm_pkg_mgr_server.c: pkgmgr_request(194) > Called
06-03 20:14:54.426+0900 D/PKGMGR  (12863): comm_pkg_mgr_server.c: pkgmgr_request(203) > [SECURE_LOG] Call request callback(obj, org.example.gearcon_1629359098, 11, rpm, org.example.gearcon, , *ret)
06-03 20:14:54.426+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: req_cb(431) > [SECURE_LOG] >> in callback >> Got request: [org.example.gearcon_1629359098] [11] [rpm] [org.example.gearcon] [] []
06-03 20:14:54.426+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: __register_signal_handler(382) > signal: SIGCHLD succeed
06-03 20:14:54.426+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: __register_signal_handler(384) > g_timeout_add_seconds() Added to Main Loop
06-03 20:14:54.426+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: req_cb(450) > req_type=(11)  backend_flag=(0)
06-03 20:14:54.426+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: queue_job(1168) > saved queue status. Now try fork()
06-03 20:14:54.426+0900 D/PKGMGR_SERVER(12864): pkgmgr-server.c: queue_job(1175) > child forked [0] for request type [11]
06-03 20:14:54.426+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: queue_job(1175) > child forked [12864] for request type [11]
06-03 20:14:54.426+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: queue_job(1347) > parent exit
06-03 20:14:54.456+0900 D/PKGMGR_SERVER(12864): pkgmgr-server.c: __make_pid_info_file(825) > File path = /tmp/org.example.gearcon
06-03 20:14:54.456+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: sighandler(326) > child exit [12864]
06-03 20:14:54.456+0900 D/PKGMGR_SERVER(12863): pkgmgr-server.c: sighandler(341) > child NORMAL exit [12864]
06-03 20:14:54.986+0900 D/AUL_AMD ( 2277): amd_request.c: __request_handler(506) > __request_handler: 0
06-03 20:14:54.986+0900 D/AUL_AMD ( 2277): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.gearcon
06-03 20:14:54.986+0900 D/AUL     ( 2277): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 12912, pid = 12914
06-03 20:14:54.986+0900 D/AUL_AMD ( 2277): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : (null)
06-03 20:14:54.986+0900 D/AUL_AMD ( 2277): amd_launch.c: _start_app(1803) > process_pool: false
06-03 20:14:54.986+0900 D/AUL_AMD ( 2277): amd_launch.c: _start_app(1806) > h/w acceleration: SYS
06-03 20:14:54.986+0900 D/AUL_AMD ( 2277): amd_launch.c: _start_app(1808) > [SECURE_LOG] appid: org.example.gearcon
06-03 20:14:54.986+0900 D/AUL_AMD ( 2277): amd_launch.c: __set_appinfo_for_launchpad(1978) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-03 20:14:54.986+0900 D/AUL     ( 2277): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
06-03 20:14:54.986+0900 D/AUL_PAD ( 2297): launchpad.c: __launchpad_main_loop(644) > [SECURE_LOG] pkg name : org.example.gearcon
06-03 20:14:54.986+0900 D/AUL_PAD ( 2297): launchpad.c: __modify_bundle(381) > parsing app_path: No arguments
06-03 20:14:54.986+0900 D/AUL_PAD ( 2297): launchpad.c: __launchpad_main_loop(704) > [SECURE_LOG] ==> real launch pid : 12915 /opt/usr/apps/org.example.gearcon/bin/gearcon
06-03 20:14:54.986+0900 D/AUL_PAD (12915): launchpad.c: __launchpad_main_loop(671) > lock up test log(no error) : fork done
06-03 20:14:54.986+0900 D/AUL_PAD ( 2297): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-03 20:14:54.986+0900 D/AUL_PAD (12915): launchpad.c: __launchpad_main_loop(682) > lock up test log(no error) : prepare exec - first done
06-03 20:14:54.996+0900 D/AUL_PAD (12915): launchpad.c: __prepare_exec(137) > [SECURE_LOG] pkg_name : org.example.gearcon / pkg_type : rpm / app_path : /opt/usr/apps/org.example.gearcon/bin/gearcon 
06-03 20:14:54.996+0900 D/AUL_PAD (12915): launchpad.c: __launchpad_main_loop(697) > lock up test log(no error) : prepare exec - second done
06-03 20:14:54.996+0900 D/AUL_PAD (12915): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.gearcon/bin/gearcon##
06-03 20:14:54.996+0900 D/AUL_PAD (12915): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-03 20:14:54.996+0900 D/AUL_PAD (12915): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-03 20:14:54.996+0900 D/LAUNCH  (12915): launchpad.c: __real_launch(230) > [SECURE_LOG] [/opt/usr/apps/org.example.gearcon/bin/gearcon:Platform:launchpad:done]
06-03 20:14:54.996+0900 I/efl-extension(12915): efl_extension.c: eext_mod_init(39) > Init
06-03 20:14:54.996+0900 I/CAPI_APPFW_APPLICATION(12915): app_main.c: ui_app_main(701) > app_efl_main
06-03 20:14:54.996+0900 D/LAUNCH  (12915): appcore-efl.c: appcore_efl_main(1597) > [gearcon:Application:main:done]
06-03 20:14:55.026+0900 D/APP_CORE(12915): appcore-efl.c: __before_loop(1030) > elm_config_preferred_engine_set is not called
06-03 20:14:55.026+0900 D/AUL     (12915): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 12915 is org.example.gearcon
06-03 20:14:55.026+0900 D/APP_CORE(12915): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.gearcon/res/locale
06-03 20:14:55.026+0900 D/APP_CORE(12915): appcore-i18n.c: update_region(74) > *****appcore setlocale=en_GB.UTF-8
06-03 20:14:55.026+0900 D/AUL     (12915): app_sock.c: __create_server_sock(141) > pg path - already exists
06-03 20:14:55.026+0900 D/LAUNCH  (12915): appcore-efl.c: __before_loop(1048) > [gearcon:Platform:appcore_init:done]
06-03 20:14:55.026+0900 I/CAPI_APPFW_APPLICATION(12915): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
06-03 20:14:55.066+0900 E/EFL     (12915): eina_module<12915> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-03 20:14:55.066+0900 E/EFL     (12915): ecore_evas<12915> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
06-03 20:14:55.076+0900 E/EFL     (12915): eina_module<12915> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
06-03 20:14:55.076+0900 I/efl-extension(12915): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(593) > rsd is initialized!!
06-03 20:14:55.086+0900 I/efl-extension(12915): efl_extension_rotary.c: eext_rotary_object_event_callback_add(163) > In
06-03 20:14:55.086+0900 E/efl-extension(12915): efl_extension_rotary.c: eext_rotary_event_handler_add(93) > init_count: 0
06-03 20:14:55.086+0900 I/efl-extension(12915): efl_extension_rotary.c: _init_Xi2_system(330) > In
06-03 20:14:55.086+0900 I/efl-extension(12915): efl_extension_rotary.c: _init_Xi2_system(391) > Done
06-03 20:14:55.086+0900 I/efl-extension(12915): efl_extension_rotary_selector.c: _event_area_callback_add(511) > called!!
06-03 20:14:55.086+0900 E/efl-extension(12915): efl_extension_rotary.c: eext_rotary_object_event_activated_set(299) > eext_rotary_object_event_activated_set : 0xb2237858, elm_layout, _activated_obj : 0x0, activated : 1
06-03 20:14:55.096+0900 D/AUL_PAD ( 2297): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
06-03 20:14:55.096+0900 D/AUL_PAD ( 2297): sigchild.h: __send_app_launch_signal(112) > send launch signal done
06-03 20:14:55.096+0900 D/AUL_PAD ( 2297): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
06-03 20:14:55.096+0900 D/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-03 20:14:55.096+0900 E/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(264) > access
06-03 20:14:55.096+0900 D/RESOURCED( 2483): proc-noti.c: recv_str(87) > [recv_str,87] str is null
06-03 20:14:55.096+0900 D/RESOURCED( 2483): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2277
06-03 20:14:55.096+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.gearcon, pid 12915, type 4 
06-03 20:14:55.096+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.gearcon, 12915
06-03 20:14:55.096+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.gearcon with pkgname
06-03 20:14:55.096+0900 E/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 356
06-03 20:14:55.096+0900 D/RESOURCED( 2483): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
06-03 20:14:55.116+0900 D/LAUNCH  (12915): appcore-efl.c: __before_loop(1066) > [gearcon:Application:create:done]
06-03 20:14:55.126+0900 D/APP_CORE(12915): appcore-efl.c: __check_wm_rotation_support(765) > Disable window manager rotation
06-03 20:14:55.126+0900 D/APP_CORE(12915): appcore-rotation.c: __changed_cb(123) > [APP 12915] Rotation: 0 -> 1
06-03 20:14:55.126+0900 D/APP_CORE(12915): appcore-rotation.c: __changed_cb(128) > [APP 12915] Rotation: 0 -> 1
06-03 20:14:55.126+0900 I/CAPI_APPFW_APPLICATION(12915): app_main.c: _ui_app_appcore_rotation_event(483) > _ui_app_appcore_rotation_event
06-03 20:14:55.126+0900 E/W_HOME  ( 2375): main.c: _window_focus_out_cb(885) > win[23068675], ev->win[23068679]
06-03 20:14:55.126+0900 D/APPS    ( 2375): apps_main.c: _window_focus_out_cb(308) >  focus out
06-03 20:14:55.126+0900 E/W_HOME  ( 2375): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
06-03 20:14:55.126+0900 D/APPS    ( 2375): apps_main.c: apps_main_pause(656) >  Pause starts
06-03 20:14:55.126+0900 D/APPS    ( 2375): apps_main.c: apps_main_pause(676) >  Pause done
06-03 20:14:55.136+0900 D/APP_CORE(12915): appcore-efl.c: __show_cb(839) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00002
06-03 20:14:55.136+0900 D/APP_CORE(12915): appcore-efl.c: __add_win(685) > [EVENT_TEST][EVENT] __add_win WIN:1c00002
06-03 20:14:55.256+0900 D/APP_CORE( 2375): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1600007 fully_obscured 1
06-03 20:14:55.256+0900 D/APP_CORE( 2375): appcore-efl.c: __visibility_cb(897) > bvisibility 0, b_active 1
06-03 20:14:55.256+0900 D/APP_CORE( 2375): appcore-efl.c: __visibility_cb(911) >  Go to Pasue state 
06-03 20:14:55.256+0900 D/APP_CORE( 2375): appcore-efl.c: __do_app(471) > [APP 2375] Event: PAUSE State: RUNNING
06-03 20:14:55.256+0900 D/APP_CORE( 2375): appcore-efl.c: __do_app(543) > [APP 2375] PAUSE
06-03 20:14:55.256+0900 I/CAPI_APPFW_APPLICATION( 2375): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-03 20:14:55.256+0900 D/W_HOME  ( 2375): main.c: _pause_cb(600) > Paused
06-03 20:14:55.256+0900 E/W_HOME  ( 2375): main.c: _pause_cb(603) > paused already
06-03 20:14:55.256+0900 D/APP_CORE( 2375): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
06-03 20:14:55.256+0900 E/APP_CORE( 2375): appcore-efl.c: __trm_app_info_send_socket(234) > access
06-03 20:14:55.266+0900 D/AUL_AMD ( 2277): amd_launch.c: __e17_status_handler(1939) > pid(12915) status(3)
06-03 20:14:55.266+0900 D/RESOURCED( 2483): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2375, type = 2
06-03 20:14:55.266+0900 D/RESOURCED( 2483): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 12915, type = 0
06-03 20:14:55.266+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 12915
06-03 20:14:55.266+0900 I/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 12915, oom : 200
06-03 20:14:55.266+0900 E/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
06-03 20:14:55.306+0900 D/APP_CORE(12915): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 0
06-03 20:14:55.306+0900 D/APP_CORE(12915): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active -1
06-03 20:14:55.306+0900 D/APP_CORE(12915): appcore-efl.c: __visibility_cb(900) >  Go to Resume state
06-03 20:14:55.306+0900 D/APP_CORE(12915): appcore-efl.c: __do_app(471) > [APP 12915] Event: RESUME State: CREATED
06-03 20:14:55.306+0900 D/LAUNCH  (12915): appcore-efl.c: __do_app(566) > [gearcon:Application:resume:start]
06-03 20:14:55.306+0900 D/LAUNCH  (12915): appcore-efl.c: __do_app(580) > [gearcon:Application:resume:done]
06-03 20:14:55.306+0900 D/LAUNCH  (12915): appcore-efl.c: __do_app(582) > [gearcon:Application:Launching:done]
06-03 20:14:55.316+0900 D/APP_CORE(12915): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
06-03 20:14:55.316+0900 E/APP_CORE(12915): appcore-efl.c: __trm_app_info_send_socket(234) > access
06-03 20:14:55.416+0900 D/APP_CORE(12915): appcore.c: __aul_handler(423) > [APP 12915]     AUL event: AUL_START
06-03 20:14:55.416+0900 D/APP_CORE(12915): appcore-efl.c: __do_app(471) > [APP 12915] Event: RESET State: CREATED
06-03 20:14:55.416+0900 D/APP_CORE(12915): appcore-efl.c: __do_app(497) > [APP 12915] RESET
06-03 20:14:55.416+0900 D/LAUNCH  (12915): appcore-efl.c: __do_app(499) > [gearcon:Application:reset:start]
06-03 20:14:55.426+0900 I/CAPI_APPFW_APPLICATION(12915): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-03 20:14:55.426+0900 D/APP_SVC (12915): appsvc.c: __set_bundle(161) > __set_bundle
06-03 20:14:55.426+0900 D/TUL     (12915): tul_init is needed
06-03 20:14:55.446+0900 E/CAPI_NETWORK_CONNECTION(12915): connection.c: connection_create(360) > Access denied
06-03 20:14:55.446+0900 D/TUL     (12915): connection header fail
06-03 20:14:55.456+0900 E/CAPI_NETWORK_CONNECTION(12915): connection.c: connection_get_ip_address(435) > Invalid parameter
06-03 20:14:55.456+0900 D/TUL     (12915): ip_address not obtained
06-03 20:14:55.476+0900 W/CRASH_MANAGER(12777): worker.c: worker_job(1189) > 1112915676561149648849

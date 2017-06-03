S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20170222.0733
Build-Date: 2017.02.22 07:33:10

Crash Information
Process Name: gearcon
PID: 8453
Date: 2017-06-03 14:59:38+0900
Executable File Path: /opt/usr/apps/org.example.gearcon/bin/gearcon
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb67a0c60, esi = 0x00000000
ebp = 0xbfd5e4f8, esp = 0xbfd5e4c0
eax = 0x00000000, ebx = 0xb67b5888
ecx = 0x00000006, edx = 0xb9092108
eip = 0xb67985f8

Memory Information
MemTotal:      123 KB
MemFree:        52 KB
Buffers:         9 KB
Cached:     127056 KB
VmPeak:     165188 KB
VmSize:     133760 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22332 KB
VmRSS:       22332 KB
VmData:      67816 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32656 KB
VmPTE:          96 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8453 TID = 8453
8453 8460 8461 8462 

Maps Information
b2b0a000 b2b0b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2b0c000 b2b14000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b2f000 b2b30000 r-xp /usr/lib/edje/modules/feedback/linux-gnu-i686-1.0.0/module.so
b2b35000 b2b37000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnu-i686-1.7.99/module.so
b2b44000 b2b45000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b2b46000 b2b6a000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b2b6f000 b2b7d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b2b7e000 b2b8d000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3ba5000 b3ba8000 r-xp /usr/lib/libdri2.so.0.0.0
b3ba9000 b3bb4000 r-xp /usr/lib/libdrm.so.2.4.0
b3bb5000 b3bbe000 r-xp /usr/lib/libtbm.so.1.0.0
b3bbf000 b3bc6000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3bc7000 b3bd0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3bd1000 b3bd8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3bd9000 b3bdf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3be0000 b3be8000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3be9000 b3bed000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3bee000 b3c0b000 r-xp /usr/lib/libtts.so
b3c0c000 b3d50000 r-xp /usr/lib/libcairo.so.2.11200.14
b3d54000 b3d6c000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3d6d000 b3d90000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3d91000 b3da1000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3da3000 b3da5000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b3da6000 b3da9000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3dac000 b3daf000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3db1000 b3dbc000 r-xp /lib/libnss_files-2.13.so
b3fbe000 b3fe5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3fe6000 b400b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b400c000 b412d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b413d000 b4173000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4175000 b4178000 r-xp /usr/lib/libiniparser.so.0
b417a000 b4185000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4186000 b418f000 r-xp /usr/lib/libappsvc.so.0.1.0
b4190000 b4193000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4197000 b41a1000 r-xp /opt/usr/apps/org.example.gearcon/bin/gearcon
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

Callstack Information (PID:8453)
Call Stack Count: 29
 0: (0xb67985f8) [/usr/lib/libedje.so.1] + 0x815f8
 1: (0xb679877c) [/usr/lib/libedje.so.1] + 0x8177c
 2: (0xb6776ed2) [/usr/lib/libedje.so.1] + 0x5fed2
 3: (0xb678aef8) [/usr/lib/libedje.so.1] + 0x73ef8
 4: (0xb68485d0) [/usr/lib/libevas.so.1] + 0x485d0
 5: evas_object_del + 0x2bc (0xb683afdc) [/usr/lib/libevas.so.1] + 0x3afdc
 6: (0xb6b2fb18) [/usr/lib/libelementary.so.1] + 0x16bb18
 7: (0xb6ac0bca) [/usr/lib/libelementary.so.1] + 0xfcbca
 8: (0xb68485d0) [/usr/lib/libevas.so.1] + 0x485d0
 9: evas_object_del + 0x2bc (0xb683afdc) [/usr/lib/libevas.so.1] + 0x3afdc
10: _elm_widget_item_free + 0xd0 (0xb6b36770) [/usr/lib/libelementary.so.1] + 0x172770
11: _elm_widget_item_del + 0xe8 (0xb6b36988) [/usr/lib/libelementary.so.1] + 0x172988
12: (0xb6a169c6) [/usr/lib/libelementary.so.1] + 0x529c6
13: (0xb6abc5c6) [/usr/lib/libelementary.so.1] + 0xf85c6
14: (0xb6781d10) [/usr/lib/libedje.so.1] + 0x6ad10
15: (0xb6789142) [/usr/lib/libedje.so.1] + 0x72142
16: (0xb6782dec) [/usr/lib/libedje.so.1] + 0x6bdec
17: (0xb678331f) [/usr/lib/libedje.so.1] + 0x6c31f
18: (0xb67834d4) [/usr/lib/libedje.so.1] + 0x6c4d4
19: (0xb72b5f32) [/usr/lib/libecore.so.1] + 0xcf32
20: (0xb72b2519) [/usr/lib/libecore.so.1] + 0x9519
21: (0xb72b747a) [/usr/lib/libecore.so.1] + 0xe47a
22: ecore_main_loop_begin + 0x3f (0xb72b79cf) [/usr/lib/libecore.so.1] + 0xe9cf
23: elm_run + 0x17 (0xb6acd0f7) [/usr/lib/libelementary.so.1] + 0x1090f7
24: appcore_efl_main + 0x418 (0xb773dfe8) [/usr/lib/libappcore-efl.so.1] + 0x2fe8
25: ui_app_main + 0x130 (0xb6bda4c0) [/usr/lib/libcapi-appfw-application.so.0] + 0x24c0
26: main + 0x2fb (0xb419d08b) [/opt/usr/apps/org.example.gearcon/bin/gearcon] + 0x608b
27: create_scroller + 0x9 (0xb776e659) [/opt/usr/apps/org.example.gearcon/bin/gearcon] + 0xb776e659
28: __libc_start_main + 0xf3 (0xb746e1a3) [/lib/libc.so.6] + 0x191a3
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
oc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.gearcon with pkgname
06-03 14:59:28.804+0900 E/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 370
06-03 14:59:28.804+0900 D/RESOURCED( 2483): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
06-03 14:59:28.814+0900 D/APP_CORE( 8453): appcore-efl.c: __show_cb(839) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
06-03 14:59:28.814+0900 D/APP_CORE( 8453): appcore-efl.c: __add_win(685) > [EVENT_TEST][EVENT] __add_win WIN:1e00002
06-03 14:59:28.904+0900 D/APP_CORE( 7841): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 1
06-03 14:59:28.904+0900 D/APP_CORE( 7841): appcore-efl.c: __visibility_cb(897) > bvisibility 0, b_active 1
06-03 14:59:28.904+0900 D/APP_CORE( 7841): appcore-efl.c: __visibility_cb(911) >  Go to Pasue state 
06-03 14:59:28.904+0900 D/APP_CORE( 7841): appcore-efl.c: __do_app(471) > [APP 7841] Event: PAUSE State: RUNNING
06-03 14:59:28.904+0900 D/APP_CORE( 7841): appcore-efl.c: __do_app(543) > [APP 7841] PAUSE
06-03 14:59:28.904+0900 I/CAPI_APPFW_APPLICATION( 7841): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-03 14:59:28.904+0900 D/APP_CORE( 7841): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
06-03 14:59:28.904+0900 E/APP_CORE( 7841): appcore-efl.c: __trm_app_info_send_socket(234) > access
06-03 14:59:28.904+0900 D/RESOURCED( 2483): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 7841, type = 2
06-03 14:59:28.904+0900 D/AUL_AMD ( 2277): amd_launch.c: __e17_status_handler(1939) > pid(8453) status(3)
06-03 14:59:28.904+0900 D/RESOURCED( 2483): cpu.c: cpu_background_state(100) > [cpu_background_state,100] cpu_background_state : pid = 7841, appname = settingsui
06-03 14:59:28.904+0900 D/RESOURCED( 2483): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/service/cgroup.procs, value 7841
06-03 14:59:28.904+0900 I/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/background/cgroup.procs, pid : 7841, oom : 300
06-03 14:59:28.904+0900 E/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/background/cgroup.procs open failed
06-03 14:59:28.904+0900 D/RESOURCED( 2483): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 8453, type = 0
06-03 14:59:28.904+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 8453
06-03 14:59:28.904+0900 I/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 8453, oom : 200
06-03 14:59:28.904+0900 E/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
06-03 14:59:28.944+0900 D/APP_CORE( 8453): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1e00002 fully_obscured 0
06-03 14:59:28.944+0900 D/APP_CORE( 8453): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active -1
06-03 14:59:28.944+0900 D/APP_CORE( 8453): appcore-efl.c: __visibility_cb(900) >  Go to Resume state
06-03 14:59:29.014+0900 D/APP_CORE( 8453): appcore.c: __aul_handler(423) > [APP 8453]     AUL event: AUL_START
06-03 14:59:29.014+0900 D/APP_CORE( 8453): appcore-efl.c: __do_app(471) > [APP 8453] Event: RESET State: CREATED
06-03 14:59:29.014+0900 D/APP_CORE( 8453): appcore-efl.c: __do_app(497) > [APP 8453] RESET
06-03 14:59:29.014+0900 D/LAUNCH  ( 8453): appcore-efl.c: __do_app(499) > [gearcon:Application:reset:start]
06-03 14:59:29.014+0900 I/CAPI_APPFW_APPLICATION( 8453): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-03 14:59:29.014+0900 D/APP_SVC ( 8453): appsvc.c: __set_bundle(161) > __set_bundle
06-03 14:59:29.014+0900 D/LAUNCH  ( 8453): appcore-efl.c: __do_app(506) > [gearcon:Application:reset:done]
06-03 14:59:29.014+0900 I/APP_CORE( 8453): appcore-efl.c: __do_app(512) > Legacy lifecycle: 0
06-03 14:59:29.014+0900 I/APP_CORE( 8453): appcore-efl.c: __do_app(514) > [APP 8453] Initial Launching, call the resume_cb
06-03 14:59:29.014+0900 I/CAPI_APPFW_APPLICATION( 8453): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-03 14:59:29.014+0900 D/APP_CORE( 8453): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
06-03 14:59:29.124+0900 D/APP_CORE( 8453): appcore.c: __prt_ltime(183) > [APP 8453] first idle after reset: 439 msec
06-03 14:59:29.804+0900 D/AUL_AMD ( 2277): amd_request.c: __add_history_handler(255) > [SECURE_LOG] add rua history org.example.gearcon /opt/usr/apps/org.example.gearcon/bin/gearcon
06-03 14:59:29.804+0900 D/RUA     ( 2277): rua.c: rua_add_history(179) > rua_add_history start
06-03 14:59:29.814+0900 D/RUA     ( 2277): rua.c: rua_add_history(247) > rua_add_history ok
06-03 14:59:30.004+0900 D/PKGMGR_SERVER( 8308): pkgmgr-server.c: exit_server(724) > exit_server Start
06-03 14:59:30.004+0900 D/PKGMGR_SERVER( 8308): pkgmgr-server.c: main(1516) > Quit main loop.
06-03 14:59:30.004+0900 D/PKGMGR_SERVER( 8308): pkgmgr-server.c: main(1524) > package manager server terminated.
06-03 14:59:33.354+0900 D/STARTER ( 2368): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
06-03 14:59:33.354+0900 E/AUL_AMD ( 2277): amd_status.c: __lcd_status_cb(680) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
06-03 14:59:33.354+0900 W/STARTER ( 2368): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
06-03 14:59:33.354+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: on_changed_receive(1293) > org.tizen.system.deviced.display - LCDOn
06-03 14:59:33.354+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-03 14:59:33.354+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-03 14:59:33.354+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: preference_get_int(1063) > preference_get_int(2384) : key(clock_font_color) error
06-03 14:59:33.354+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-03 14:59:33.354+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-03 14:59:33.354+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2384): preference.c: preference_get_int(1063) > preference_get_int(2384) : key(showdate) error
06-03 14:59:33.354+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: clock_view_set_info_time(877) > show_date:1
06-03 14:59:33.354+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Sat, 3 Jun][1496469573]
06-03 14:59:33.354+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: clock_view_set_info_time(885) > 
06-03 14:59:33.354+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[pm][1496469573]
06-03 14:59:33.354+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[2:59][1496469573]
06-03 14:59:33.354+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: clock_view_set_info_time(899) > utc_time=2:59, utc_ampm=[2]pm
06-03 14:59:33.354+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>2:59<font_size=24><font=Tizen:style=Bold>pm</font></font_size></color>
06-03 14:59:33.354+0900 D/STARTER ( 2368): hw_key_w.c: _key_press_cb(1107) > [_key_press_cb:1107] _key_press_cb : XF86PowerOff Pressed
06-03 14:59:33.354+0900 W/STARTER ( 2368): hw_key_w.c: _key_press_cb(1112) > [_key_press_cb:1112] POWER Key is pressed
06-03 14:59:33.354+0900 W/STARTER ( 2368): hw_key_w.c: _key_press_cb(1118) > [_key_press_cb:1118] LCD state : 3
06-03 14:59:33.354+0900 E/STARTER ( 2368): hw_key_w.c: _key_press_cb(1127) > [_key_press_cb:1127] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
06-03 14:59:33.354+0900 W/STARTER ( 2368): hw_key_w.c: _key_press_cb(1130) > [_key_press_cb:1130] Simple Clock state : 0
06-03 14:59:33.354+0900 W/STARTER ( 2368): hw_key_w.c: _key_press_cb(1135) > [_key_press_cb:1135] powerkey count : 1
06-03 14:59:33.354+0900 D/STARTER ( 2368): hw_key_w.c: _key_press_cb(1149) > [_key_press_cb:1149] create long press timer
06-03 14:59:33.354+0900 D/IDLE-CLOCK-DIGITAL( 2384): clock_view.c: _device_state_changed_cb(1131) > DISPLAY STATE [0]
06-03 14:59:33.354+0900 D/NET_NFC_MANAGER( 2414): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
06-03 14:59:33.354+0900 D/NET_NFC_MANAGER( 2414): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
06-03 14:59:33.354+0900 D/DATA_PROVIDER_MASTER( 2420): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-03 14:59:33.354+0900 D/NET_NFC_MANAGER( 2414): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_configure_discovery(2040) > [0;36m BEGIN >>>>[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_configure_discovery(2063) > [0;36m Create Thread[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_init(1863) > [0;36m BEGIN >>>>[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_init(1865) > [0;36m start stack init [0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: _net_nfc_emul_controller_start_thread(1828) > [0;36m BEGIN >>>>[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: _net_nfc_emul_controller_start_thread(1835) > [0;36m END >>>>[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_init(1880) > [0;36m Stack init finished[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_init(1885) > [0;36m END >>>>[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: net_nfc_emul_controller_configure_discovery(2068) > [0;36m END >>>>[0;m
06-03 14:59:33.354+0900 D/NET_NFC_MANAGER( 2414): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: emul_ReaderThread(1635) > [0;36m emul_ReaderThread START >>>>[0;m
06-03 14:59:33.354+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: emul_ReaderThread(1646) > file path : /dev/nfc0
06-03 14:59:33.394+0900 D/APP_CORE( 8453): appcore-rotation.c: __changed_cb(123) > [APP 8453] Rotation: 0 -> 1
06-03 14:59:33.394+0900 D/APP_CORE( 8453): appcore-rotation.c: __changed_cb(128) > [APP 8453] Rotation: 0 -> 1
06-03 14:59:33.394+0900 I/CAPI_APPFW_APPLICATION( 8453): app_main.c: _ui_app_appcore_rotation_event(483) > _ui_app_appcore_rotation_event
06-03 14:59:33.404+0900 E/NFC_PLUGIN_EMUL( 2414): oem_emul.c: emul_ReaderThread(1687) > [0;36m epoll wait >>>>[0;m
06-03 14:59:33.464+0900 W/W_HOME  ( 2375): dbus.c: _dbus_message_recv_cb(178) > LCD on
06-03 14:59:33.464+0900 W/W_HOME  ( 2375): main.c: _lcd_on_cb(951) > LCD: off->on
06-03 14:59:33.464+0900 D/W_HOME  ( 2375): clock_event.c: _display_state_cb(194) > LCD: off->on
06-03 14:59:33.464+0900 D/W_HOME  ( 2375): clock_view.c: clock_view_event_handler(843) > event:40000 received
06-03 14:59:33.464+0900 D/W_HOME  ( 2375): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
06-03 14:59:33.464+0900 D/APP_CORE( 7841): appcore-rotation.c: __changed_cb(123) > [APP 7841] Rotation: 1 -> 1
06-03 14:59:33.464+0900 D/STARTER ( 2368): hw_key_w.c: _key_release_cb(1038) > [_key_release_cb:1038] _key_release_cb : XF86PowerOff Released
06-03 14:59:33.464+0900 W/STARTER ( 2368): hw_key_w.c: _key_release_cb(1043) > [_key_release_cb:1043] POWER Key is released
06-03 14:59:33.464+0900 D/STARTER ( 2368): hw_key_w.c: _key_release_cb(1049) > [_key_release_cb:1049] delete long press timer
06-03 14:59:33.464+0900 D/STARTER ( 2368): hw_key_w.c: _key_release_cb(1075) > [_key_release_cb:1075] lcd off --> [0.400000]sec timer
06-03 14:59:33.884+0900 W/STARTER ( 2368): hw_key_w.c: _powerkey_timer_cb(777) > [_powerkey_timer_cb:777] _powerkey_timer_cb, powerkey count[1]
06-03 14:59:33.884+0900 E/STARTER ( 2368): hw_key_w.c: _powerkey_timer_cb(796) > [SECURE_LOG] [_powerkey_timer_cb:796] Failed to get vconfkey[memory/setup_wizard/state]
06-03 14:59:33.884+0900 E/STARTER ( 2368): hw_key_w.c: _powerkey_timer_cb(825) > [SECURE_LOG] [_powerkey_timer_cb:825] Failed to get vconfkey[db/wms/safety_enable]
06-03 14:59:33.884+0900 W/STARTER ( 2368): hw_key_w.c: _powerkey_timer_cb(891) > [_powerkey_timer_cb:891] just turn on LCD by powerkey.. starter ignore powerkey operation
06-03 14:59:34.034+0900 D/APP_CORE( 7841): appcore-efl.c: __do_app(471) > [APP 7841] Event: MEM_FLUSH State: PAUSED
06-03 14:59:34.464+0900 I/GESTURE ( 2239): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-03 14:59:34.534+0900 I/GESTURE ( 2239): gesture.c: GestureRecognize_GroupTap(734) > [GroupTap][F] num_pressed(=0) != prev_num_pressed(=0) OR 0 finger tap event was not grabbed/selected !
06-03 14:59:34.534+0900 D/EFL     ( 8453): ecore_x<8453> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=10010469 button=1
06-03 14:59:34.534+0900 D/EFL     ( 8453): ecore_x<8453> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=10010537 button=1
06-03 14:59:34.534+0900 I/gearcon ( 8453): hyunykung ITEM name PC Setting clicked 
06-03 14:59:34.534+0900 I/efl-extension( 8453): efl_extension_rotary.c: eext_rotary_object_event_callback_add(163) > In
06-03 14:59:34.534+0900 I/efl-extension( 8453): efl_extension_rotary.c: eext_rotary_object_event_callback_add(163) > In
06-03 14:59:34.534+0900 E/efl-extension( 8453): efl_extension_rotary.c: eext_rotary_object_event_activated_set(299) > eext_rotary_object_event_activated_set : 0xb8fe9378, elm_image, _activated_obj : 0xb8f61fd8, activated : 1
06-03 14:59:34.534+0900 E/efl-extension( 8453): efl_extension_rotary.c: eext_rotary_object_event_activated_set(307) > Activation delete!!!!
06-03 14:59:34.534+0900 E/EFL     ( 8453): eina_module<8453> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-03 14:59:35.364+0900 I/GESTURE ( 2239): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-03 14:59:35.434+0900 I/GESTURE ( 2239): gesture.c: GestureRecognize_GroupTap(734) > [GroupTap][F] num_pressed(=0) != prev_num_pressed(=0) OR 0 finger tap event was not grabbed/selected !
06-03 14:59:35.434+0900 D/EFL     ( 8453): ecore_x<8453> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=10011371 button=1
06-03 14:59:35.434+0900 D/EFL     ( 8453): ecore_x<8453> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=10011438 button=1
06-03 14:59:35.444+0900 E/efl-extension( 8453): efl_extension_rotary.c: eext_rotary_object_event_activated_set(299) > eext_rotary_object_event_activated_set : 0xb9214860, elm_slider, _activated_obj : 0xb8fe9378, activated : 1
06-03 14:59:35.444+0900 E/efl-extension( 8453): efl_extension_rotary.c: eext_rotary_object_event_activated_set(307) > Activation delete!!!!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 E/EFL     ( 8453): edje<8453> edje_util.c:3592 edje_object_size_min_restricted_calc() group elm/slider/horizontal/default has a non-fixed part 'elm.swallow.icon'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.454+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.464+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.464+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.464+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.464+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.464+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.494+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.494+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.494+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.494+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.494+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.564+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.564+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.564+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.564+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.564+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.604+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.604+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.604+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.604+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.604+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.644+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.644+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.644+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.644+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.644+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.674+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.684+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.724+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.724+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.724+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.724+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.724+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.774+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.774+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.774+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.774+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.774+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.804+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.804+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.804+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.804+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.804+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.874+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.874+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.874+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.874+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.874+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:35.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:36.094+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:36.094+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:36.094+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:36.094+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:36.094+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.884+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.934+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.934+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.934+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.934+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.934+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.964+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.964+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.964+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.964+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:37.964+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.044+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.044+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.044+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.044+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.044+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.114+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.114+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.114+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.114+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.114+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.144+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.144+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.144+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.144+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.144+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.194+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.194+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.194+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.194+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.194+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.244+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.244+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.244+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.244+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.244+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.284+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.284+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.284+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.284+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.284+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.334+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.334+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.334+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.334+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.334+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 E/EFL     ( 8453): elementary<8453> elm_widget.c:386 _elm_widget_sub_object_del_func() removing sub object 0xb91eb4d0 ((null)) from parent 0xb908e550 (elm_layout), but elm-parent is different (nil) ((null))!
06-03 14:59:38.344+0900 E/EFL     ( 8453): elementary<8453> elm_widget.c:657 _smart_del() failed to remove sub object 0xb91eb4d0 from 0xb908e550
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.344+0900 F/EFL     ( 8453): evas_main<8453> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
06-03 14:59:38.394+0900 W/CRASH_MANAGER( 8480): worker.c: worker_job(1189) > 1108453676561149646957

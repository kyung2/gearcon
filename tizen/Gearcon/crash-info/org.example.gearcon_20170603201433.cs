S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20170222.0733
Build-Date: 2017.02.22 07:33:10

Crash Information
Process Name: gearcon
PID: 12757
Date: 2017-06-03 20:14:33+0900
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
Cached:     134936 KB
VmPeak:     156564 KB
VmSize:     127992 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17352 KB
VmRSS:       17352 KB
VmData:      64116 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32816 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 12757 TID = 12757
12757 12764 12765 12766 

Maps Information
b294d000 b295c000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b2b12000 b2b36000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b2b3b000 b2b3e000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b2b3f000 b2b41000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnu-i686-1.7.99/module.so
b2b4e000 b2b5c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
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

Callstack Information (PID:12757)
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
nal_handle_filter(189) > callback function is end
06-03 20:14:32.036+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.036+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / install_percent / 60
06-03 20:14:32.036+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[install_percent] val[60]
06-03 20:14:32.036+0900 D/APPS    ( 2375): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.gearcon
06-03 20:14:32.036+0900 D/APPS    ( 2375): pkgmgr.c: _install_percent(469) >  package(org.example.gearcon) with 60
06-03 20:14:32.036+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.036+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.036+0900 E/PKGMGR_CERT(12701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
06-03 20:14:32.036+0900 E/PKGMGR_CERT(12701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 1 10
06-03 20:14:32.036+0900 E/PKGMGR_CERT(12701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 2 10
06-03 20:14:32.036+0900 E/PKGMGR_CERT(12701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 5
06-03 20:14:32.036+0900 E/PKGMGR_CERT(12701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 8 6
06-03 20:14:32.036+0900 E/PKGMGR_CERT(12701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 9 6
06-03 20:14:32.036+0900 E/PKGMGR_CERT(12701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 10 6
06-03 20:14:32.046+0900 E/PKGMGR_CERT(12701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
06-03 20:14:32.046+0900 E/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_make_directory(1601) > mkdir failed. appdir=[/usr/apps/org.example.gearcon/shared], errno=[2][No such file or directory]
06-03 20:14:32.056+0900 E/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.gearcon/shared]
06-03 20:14:32.056+0900 E/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.gearcon/shared/res]
06-03 20:14:32.056+0900 E/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.gearcon/tizen-manifest.xml]
06-03 20:14:32.056+0900 E/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.gearcon/author-signature.xml]
06-03 20:14:32.056+0900 E/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.gearcon/signature1.xml]
06-03 20:14:32.056+0900 E/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/share/packages/org.example.gearcon.xml]
06-03 20:14:32.056+0900 D/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1405) > Exist shared/data folder (path:[/opt/usr/apps/org.example.gearcon/shared/data])
06-03 20:14:32.076+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_unregister_package(84) > [smack] app_uninstall(org.example.gearcon), result=[0]
06-03 20:14:32.096+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.gearcon), result=[0]
06-03 20:14:32.096+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon, 5, _), result=[0]
06-03 20:14:32.096+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/shared, 5, _), result=[0]
06-03 20:14:32.096+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/shared/res, 5, _), result=[0]
06-03 20:14:32.116+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/shared/data, 2), result=[0]
06-03 20:14:32.126+0900 D/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_get_group_id(1881) > encoding done, len=[28]
06-03 20:14:32.126+0900 D/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_apply_smack(1989) > groupid = [lRCBhlfBM8hN+lAnIV9z4vodWRE=] for shared/trusted.
06-03 20:14:32.136+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/shared/trusted, 1, lRCBhlfBM8hN+lAnIV9z4vodWRE=), result=[0]
06-03 20:14:32.136+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/bin, 0, org.example.gearcon), result=[0]
06-03 20:14:32.136+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/data, 0, org.example.gearcon), result=[0]
06-03 20:14:32.136+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/lib, 0, org.example.gearcon), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/res, 0, org.example.gearcon), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/cache, 0, org.example.gearcon), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/tizen-manifest.xml, 0, org.example.gearcon), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/author-signature.xml, 0, org.example.gearcon), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/usr/apps/org.example.gearcon/signature1.xml, 0, org.example.gearcon), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/share/packages/org.example.gearcon.xml, 0, org.example.gearcon), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/storage/sdcard/apps/org.example.gearcon, 5, _), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/storage/sdcard/apps/org.example.gearcon/data, 0, org.example.gearcon), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/storage/sdcard/apps/org.example.gearcon/cache, 0, org.example.gearcon), result=[0]
06-03 20:14:32.146+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.gearcon, /opt/storage/sdcard/apps/org.example.gearcon/shared, 5, _), result=[0]
06-03 20:14:32.176+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.gearcon, /opt/storage/sdcard/apps/org.example.gearcon/shared/data, 2), result=[0]
06-03 20:14:32.176+0900 D/rpm-installer(12701): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-03 20:14:32.186+0900 D/rpm-installer(12701): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.gearcon, 7), result=[0]
06-03 20:14:32.196+0900 D/rpm-installer(12701): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-03 20:14:32.196+0900 D/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_package_reinstall(3540) > #permission applying success.
06-03 20:14:32.206+0900 D/PKGMGR  ( 2509): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / install_percent / 100
06-03 20:14:32.206+0900 D/PKGMGR  ( 2374): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / install_percent / 100
06-03 20:14:32.206+0900 D/PKGMGR  ( 2374): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[install_percent] val[100]
06-03 20:14:32.206+0900 D/PKGMGR  ( 2374): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2374): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.206+0900 D/PKGMGR  ( 2509): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[install_percent] val[100]
06-03 20:14:32.206+0900 D/PKGMGR  ( 2509): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2509): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.206+0900 D/rpm-installer(12701): coretpk-installer.c: _coretpk_installer_package_reinstall(3571) > [#]end : _coretpk_installer_package_reinstall
06-03 20:14:32.206+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / install_percent / 100
06-03 20:14:32.206+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[install_percent] val[100]
06-03 20:14:32.206+0900 D/ADD_VIEWER( 2375): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.gearcon] 100
06-03 20:14:32.206+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.206+0900 D/PKGMGR  ( 2420): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / install_percent / 100
06-03 20:14:32.206+0900 D/PKGMGR  ( 2420): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[install_percent] val[100]
06-03 20:14:32.206+0900 D/DATA_PROVIDER_MASTER( 2420): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.gearcon] 100
06-03 20:14:32.206+0900 D/PKGMGR  ( 2420): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2420): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.206+0900 D/PKGMGR  ( 2374): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / end / ok
06-03 20:14:32.206+0900 D/PKGMGR  ( 2374): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[end] val[ok]
06-03 20:14:32.206+0900 D/PKGMGR  ( 2374): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2374): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.206+0900 D/PKGMGR  ( 2411): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / install_percent / 100
06-03 20:14:32.206+0900 D/PKGMGR  ( 2411): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[install_percent] val[100]
06-03 20:14:32.206+0900 D/PKGMGR  ( 2411): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2411): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.206+0900 D/PKGMGR  ( 2411): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / end / ok
06-03 20:14:32.206+0900 D/PKGMGR  ( 2411): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[end] val[ok]
06-03 20:14:32.206+0900 D/PKGMGR  ( 2411): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2411): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.206+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [upgrade] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / end / ok
06-03 20:14:32.206+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[end] val[ok]
06-03 20:14:32.206+0900 D/PKGMGR  ( 2420): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / end / ok
06-03 20:14:32.206+0900 D/AUL_AMD ( 2277): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.gearcon), key(end), value(ok)
06-03 20:14:32.206+0900 D/PKGMGR  ( 2420): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[end] val[ok]
06-03 20:14:32.206+0900 D/AUL_AMD ( 2277): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(update), value(ok)
06-03 20:14:32.206+0900 D/DATA_PROVIDER_MASTER( 2420): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.gearcon] ok
06-03 20:14:32.206+0900 D/PKGMGR  ( 2509): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / end / ok
06-03 20:14:32.206+0900 D/PKGMGR  ( 2509): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[end] val[ok]
06-03 20:14:32.206+0900 D/PKGMGR  ( 2509): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2509): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.206+0900 D/PKGMGR  ( 2420): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2420): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.206+0900 D/AUL_AMD ( 2277): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
06-03 20:14:32.206+0900 D/AUL_AMD ( 2277): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.gearcon, comp:ui, type:rpm
06-03 20:14:32.206+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.206+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.216+0900 D/rpm-installer(12701): rpm-appcore-intf.c: main(246) > ------------------------------------------------
06-03 20:14:32.216+0900 D/rpm-installer(12701): rpm-appcore-intf.c: main(247) >  [END] rpm-installer: result=[0]
06-03 20:14:32.216+0900 D/rpm-installer(12701): rpm-appcore-intf.c: main(248) > ------------------------------------------------
06-03 20:14:32.216+0900 D/PKGMGR_SERVER(12612): pkgmgr-server.c: sighandler(326) > child exit [12701]
06-03 20:14:32.216+0900 D/PKGMGR_SERVER(12612): pkgmgr-server.c: sighandler(341) > child NORMAL exit [12701]
06-03 20:14:32.236+0900 E/RESOURCED( 2483): proc-process.c: proc_get_oom_score_adj(344) > [proc_get_oom_score_adj,344] fopen /proc/12701/oom_score_adj failed
06-03 20:14:32.236+0900 E/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(541) > [resourced_proc_status_change,541] Empty pid or process not exists. 12701
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / install_percent / 100
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[install_percent] val[100]
06-03 20:14:32.266+0900 D/W_HOME  ( 2375): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.gearcon key:install_percent val:100
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / install_percent / 100
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[install_percent] val[100]
06-03 20:14:32.266+0900 D/APPS    ( 2375): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.gearcon
06-03 20:14:32.266+0900 D/APPS    ( 2375): pkgmgr.c: _install_percent(469) >  package(org.example.gearcon) with 100
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / end / ok
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[end] val[ok]
06-03 20:14:32.266+0900 D/ADD_VIEWER( 2375): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.gearcon] ok
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / end / ok
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[end] val[ok]
06-03 20:14:32.266+0900 D/W_HOME  ( 2375): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.gearcon key:end val:ok
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.gearcon_1606762680 / coretpk / org.example.gearcon / end / ok
06-03 20:14:32.266+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[org.example.gearcon_1606762680] pkg_type[coretpk] pkgid[org.example.gearcon]key[end] val[ok]
06-03 20:14:32.266+0900 D/APPS    ( 2375): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.gearcon
06-03 20:14:32.266+0900 D/APPS    ( 2375): pkgmgr.c: _end(651) >  Package(org.example.gearcon) : key(update) - val(ok)
06-03 20:14:32.276+0900 D/APPS    ( 2375): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.gearcon]
06-03 20:14:32.276+0900 D/APPS    ( 2375): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.gearcon]'s item object
06-03 20:14:32.276+0900 D/APPS    ( 2375): db.c: apps_db_remove_item(404) >  Remove the item[org.example.gearcon]
06-03 20:14:32.286+0900 D/APPS    ( 2375): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.gearcon], name[gearcon]
06-03 20:14:32.296+0900 D/APPS    ( 2375): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.gearcon]
06-03 20:14:32.296+0900 D/DATA_PROVIDER_MASTER( 2420): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
06-03 20:14:32.296+0900 D/DATA_PROVIDER_MASTER( 2420): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
06-03 20:14:32.296+0900 D/DATA_PROVIDER_MASTER( 2420): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
06-03 20:14:32.296+0900 D/BADGE   ( 2420): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.gearcon'], count[0]
06-03 20:14:32.296+0900 D/DATA_PROVIDER_MASTER( 2420): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-03 20:14:32.296+0900 E/DATA_PROVIDER_MASTER( 2420): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
06-03 20:14:32.296+0900 D/COM_CORE( 2375): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2420, fd: -1
06-03 20:14:32.296+0900 D/COM_CORE( 2375): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2420), fd: -1
06-03 20:14:32.296+0900 D/COM_CORE( 2375): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 34 (recv_fd: -1)
06-03 20:14:32.296+0900 D/APPS    ( 2375): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.gearcon]
06-03 20:14:32.296+0900 D/DATA_PROVIDER_MASTER( 2420): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
06-03 20:14:32.296+0900 D/COM_CORE( 2420): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-03 20:14:32.296+0900 D/DATA_PROVIDER_MASTER( 2420): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
06-03 20:14:32.296+0900 D/DATA_PROVIDER_MASTER( 2420): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
06-03 20:14:32.306+0900 D/BADGE   ( 2420): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.gearcon'], count[0]
06-03 20:14:32.306+0900 D/DATA_PROVIDER_MASTER( 2420): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-03 20:14:32.306+0900 E/DATA_PROVIDER_MASTER( 2420): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
06-03 20:14:32.306+0900 D/DATA_PROVIDER_MASTER( 2420): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8741ce0 is terminated (NIL packet)
06-03 20:14:32.306+0900 D/DATA_PROVIDER_MASTER( 2420): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-03 20:14:32.306+0900 D/COM_CORE( 2375): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2420, fd: -1
06-03 20:14:32.306+0900 D/COM_CORE( 2375): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2420), fd: -1
06-03 20:14:32.306+0900 D/COM_CORE( 2375): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 34 (recv_fd: -1)
06-03 20:14:32.306+0900 D/COM_CORE( 2420): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-03 20:14:32.306+0900 D/DATA_PROVIDER_MASTER( 2420): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8741bc0 is terminated (NIL packet)
06-03 20:14:32.306+0900 D/DATA_PROVIDER_MASTER( 2420): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-03 20:14:32.306+0900 D/APPS    ( 2375): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.gearcon], name[gearcon]
06-03 20:14:32.326+0900 D/APPS    ( 2375): item.c: item_create(819) >  Icon size after ea_effect (124:127)
06-03 20:14:32.326+0900 D/BADGE   ( 2375): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.gearcon'], count[0]
06-03 20:14:32.326+0900 D/APPS    ( 2375): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
06-03 20:14:32.326+0900 D/APPS    ( 2375): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.musicplayer2]'s ordering : 1
06-03 20:14:32.326+0900 D/APPS    ( 2375): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.systemsettings]'s ordering : 2
06-03 20:14:32.326+0900 D/APPS    ( 2375): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.settingsui]'s ordering : 3
06-03 20:14:32.326+0900 D/APPS    ( 2375): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.uicomponents]'s ordering : 4
06-03 20:14:32.326+0900 D/APPS    ( 2375): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.gearcon_m]'s ordering : 5
06-03 20:14:32.326+0900 D/APPS    ( 2375): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.gearcon]'s ordering : 6
06-03 20:14:32.326+0900 D/APPS    ( 2375): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
06-03 20:14:32.336+0900 D/APPS    ( 2375): db.c: apps_db_update_item(374) >  Update the item[org.example.musicplayer2:1]
06-03 20:14:32.346+0900 D/APPS    ( 2375): db.c: apps_db_update_item(374) >  Update the item[org.example.systemsettings:2]
06-03 20:14:32.356+0900 D/APPS    ( 2375): db.c: apps_db_update_item(374) >  Update the item[org.example.settingsui:3]
06-03 20:14:32.356+0900 D/APPS    ( 2375): db.c: apps_db_update_item(374) >  Update the item[org.example.uicomponents:4]
06-03 20:14:32.366+0900 D/APPS    ( 2375): db.c: apps_db_update_item(374) >  Update the item[org.example.gearcon_m:5]
06-03 20:14:32.376+0900 D/APPS    ( 2375): db.c: apps_db_insert_item(345) >  Insert the item[org.example.gearcon:6]
06-03 20:14:32.376+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-03 20:14:32.376+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-03 20:14:32.666+0900 D/AUL_AMD ( 2277): amd_request.c: __request_handler(506) > __request_handler: 0
06-03 20:14:32.666+0900 D/AUL_AMD ( 2277): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.gearcon
06-03 20:14:32.666+0900 D/AUL     ( 2277): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 12754, pid = 12756
06-03 20:14:32.666+0900 D/AUL_AMD ( 2277): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : (null)
06-03 20:14:32.676+0900 D/AUL_AMD ( 2277): amd_launch.c: _start_app(1803) > process_pool: false
06-03 20:14:32.676+0900 D/AUL_AMD ( 2277): amd_launch.c: _start_app(1806) > h/w acceleration: SYS
06-03 20:14:32.676+0900 D/AUL_AMD ( 2277): amd_launch.c: _start_app(1808) > [SECURE_LOG] appid: org.example.gearcon
06-03 20:14:32.676+0900 D/AUL_AMD ( 2277): amd_launch.c: __set_appinfo_for_launchpad(1978) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-03 20:14:32.676+0900 D/AUL     ( 2277): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
06-03 20:14:32.676+0900 D/AUL_PAD ( 2297): launchpad.c: __launchpad_main_loop(644) > [SECURE_LOG] pkg name : org.example.gearcon
06-03 20:14:32.676+0900 D/AUL_PAD ( 2297): launchpad.c: __modify_bundle(381) > parsing app_path: No arguments
06-03 20:14:32.676+0900 D/AUL_PAD ( 2297): launchpad.c: __launchpad_main_loop(704) > [SECURE_LOG] ==> real launch pid : 12757 /opt/usr/apps/org.example.gearcon/bin/gearcon
06-03 20:14:32.676+0900 D/AUL_PAD ( 2297): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-03 20:14:32.676+0900 D/AUL_PAD (12757): launchpad.c: __launchpad_main_loop(671) > lock up test log(no error) : fork done
06-03 20:14:32.676+0900 D/AUL_PAD (12757): launchpad.c: __launchpad_main_loop(682) > lock up test log(no error) : prepare exec - first done
06-03 20:14:32.676+0900 D/AUL_PAD (12757): launchpad.c: __prepare_exec(137) > [SECURE_LOG] pkg_name : org.example.gearcon / pkg_type : rpm / app_path : /opt/usr/apps/org.example.gearcon/bin/gearcon 
06-03 20:14:32.676+0900 D/AUL_PAD (12757): launchpad.c: __launchpad_main_loop(697) > lock up test log(no error) : prepare exec - second done
06-03 20:14:32.676+0900 D/AUL_PAD (12757): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.gearcon/bin/gearcon##
06-03 20:14:32.676+0900 D/AUL_PAD (12757): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-03 20:14:32.676+0900 D/AUL_PAD (12757): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-03 20:14:32.676+0900 D/LAUNCH  (12757): launchpad.c: __real_launch(230) > [SECURE_LOG] [/opt/usr/apps/org.example.gearcon/bin/gearcon:Platform:launchpad:done]
06-03 20:14:32.686+0900 I/efl-extension(12757): efl_extension.c: eext_mod_init(39) > Init
06-03 20:14:32.686+0900 I/CAPI_APPFW_APPLICATION(12757): app_main.c: ui_app_main(701) > app_efl_main
06-03 20:14:32.696+0900 D/LAUNCH  (12757): appcore-efl.c: appcore_efl_main(1597) > [gearcon:Application:main:done]
06-03 20:14:32.716+0900 D/APP_CORE(12757): appcore-efl.c: __before_loop(1030) > elm_config_preferred_engine_set is not called
06-03 20:14:32.726+0900 D/AUL     (12757): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 12757 is org.example.gearcon
06-03 20:14:32.726+0900 D/APP_CORE(12757): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.gearcon/res/locale
06-03 20:14:32.726+0900 D/APP_CORE(12757): appcore-i18n.c: update_region(74) > *****appcore setlocale=en_GB.UTF-8
06-03 20:14:32.726+0900 D/AUL     (12757): app_sock.c: __create_server_sock(141) > pg path - already exists
06-03 20:14:32.726+0900 D/LAUNCH  (12757): appcore-efl.c: __before_loop(1048) > [gearcon:Platform:appcore_init:done]
06-03 20:14:32.726+0900 I/CAPI_APPFW_APPLICATION(12757): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
06-03 20:14:32.756+0900 E/EFL     (12757): eina_module<12757> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-03 20:14:32.776+0900 D/AUL_PAD ( 2297): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
06-03 20:14:32.776+0900 D/AUL_PAD ( 2297): sigchild.h: __send_app_launch_signal(112) > send launch signal done
06-03 20:14:32.776+0900 D/AUL_PAD ( 2297): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
06-03 20:14:32.776+0900 E/EFL     (12757): ecore_evas<12757> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
06-03 20:14:32.776+0900 D/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-03 20:14:32.776+0900 D/RESOURCED( 2483): proc-noti.c: recv_str(87) > [recv_str,87] str is null
06-03 20:14:32.776+0900 D/RESOURCED( 2483): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2277
06-03 20:14:32.776+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.gearcon, pid 12757, type 4 
06-03 20:14:32.776+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.gearcon, 12757
06-03 20:14:32.776+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.gearcon with pkgname
06-03 20:14:32.786+0900 E/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 352
06-03 20:14:32.786+0900 D/RESOURCED( 2483): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
06-03 20:14:32.786+0900 E/EFL     (12757): eina_module<12757> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
06-03 20:14:32.786+0900 E/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(264) > access
06-03 20:14:32.786+0900 I/efl-extension(12757): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(593) > rsd is initialized!!
06-03 20:14:32.796+0900 I/efl-extension(12757): efl_extension_rotary.c: eext_rotary_object_event_callback_add(163) > In
06-03 20:14:32.796+0900 E/efl-extension(12757): efl_extension_rotary.c: eext_rotary_event_handler_add(93) > init_count: 0
06-03 20:14:32.796+0900 I/efl-extension(12757): efl_extension_rotary.c: _init_Xi2_system(330) > In
06-03 20:14:32.796+0900 I/efl-extension(12757): efl_extension_rotary.c: _init_Xi2_system(391) > Done
06-03 20:14:32.796+0900 I/efl-extension(12757): efl_extension_rotary_selector.c: _event_area_callback_add(511) > called!!
06-03 20:14:32.796+0900 E/efl-extension(12757): efl_extension_rotary.c: eext_rotary_object_event_activated_set(299) > eext_rotary_object_event_activated_set : 0xb2a3b978, elm_layout, _activated_obj : 0x0, activated : 1
06-03 20:14:32.866+0900 D/LAUNCH  (12757): appcore-efl.c: __before_loop(1066) > [gearcon:Application:create:done]
06-03 20:14:32.866+0900 D/APP_CORE(12757): appcore-efl.c: __check_wm_rotation_support(765) > Disable window manager rotation
06-03 20:14:32.876+0900 D/IMMODULE(10883): isf_imf_context.cpp: isf_imf_context_focus_out(1540) > ctx : 0xb9277cc0
06-03 20:14:32.876+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: check_focus_out_by_popup_win(6153) > win type : 8
06-03 20:14:32.876+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_focus_out_cb(6181) > Application window focus OUT!
06-03 20:14:32.876+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: delete_ise_hide_timer(3795) > deleting ise_hide_timer
06-03 20:14:32.876+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(435) > win type : 8
06-03 20:14:32.876+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(677) > [SECURE_LOG] ctx : 0xb9277cc0
06-03 20:14:32.886+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _client_window_focus_out_cb(402) > ctx : 0xb9277cc0, client_window : 0x1c00002, focus-out win : 0x1c00002, focus-in win : 0x1e00002
06-03 20:14:32.886+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_focus_out_cb(6196) > Panel hides ISE
06-03 20:14:32.886+0900 D/ISF_UTILITY( 2374): scim_utility.cpp: isf_save_log(1439) > time:1496488472  pid:2374  scim_panel_agent.cpp  hide_helper  Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:32.886+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_hide_ise(5271) > slot_hide_ise ()
06-03 20:14:32.886+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: hide_ise(3804) > send request to hide helper
06-03 20:14:32.886+0900 D/ISF_UTILITY( 2374): scim_utility.cpp: isf_save_log(1439) > time:1496488472  pid:2374  scim_panel_agent.cpp  hide_helper  Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:32.886+0900 D/ISF_UTILITY( 2385): scim_utility.cpp: isf_save_log(1439) > time:1496488472  pid:2385  scim_helper.cpp  filter_event  Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:32.886+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(435) > win type : 8
06-03 20:14:32.886+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _send_input_panel_hide_request(328) > [SECURE_LOG] Send input panel hide request
06-03 20:14:32.886+0900 D/ISF_UTILITY( 2385): scim_utility.cpp: isf_save_log(1439) > time:1496488472  pid:2385  scim_helper.cpp  filter_event  Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:32.896+0900 D/ISF_UTILITY( 2374): scim_utility.cpp: isf_save_log(1439) > time:1496488472  pid:2374  scim_panel_agent.cpp  hide_ise_panel  prepare to hide ISE, 30 30
06-03 20:14:32.896+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_hide_ise(5271) > slot_hide_ise ()
06-03 20:14:32.896+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: hide_ise(3804) > send request to hide helper
06-03 20:14:32.896+0900 D/ISF_UTILITY( 2374): scim_utility.cpp: isf_save_log(1439) > time:1496488472  pid:2374  scim_panel_agent.cpp  hide_helper  Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:32.896+0900 D/ISF_UTILITY( 2385): scim_utility.cpp: isf_save_log(1439) > time:1496488472  pid:2385  scim_helper.cpp  filter_event  Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-03 20:14:32.906+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_client_message_cb(5939) > _ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_OFF_PREPARE_REQUEST
06-03 20:14:32.906+0900 W/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x1c00002 FAILED!
06-03 20:14:32.916+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: get_ise_geometry(954) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 360 0 0
06-03 20:14:32.916+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1007) > KEYBOARD_GEOMETRY_SET : 0 360 0 0
06-03 20:14:32.916+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _event_callback_call(253) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb9277cc0
06-03 20:14:32.916+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _prop_change(158) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
06-03 20:14:32.916+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _prop_change(165) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 360, w : 0, h : 0
06-03 20:14:32.916+0900 E/EFL     (10883): edje<10883> edje_util.c:3592 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 20:14:32.926+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain reset_input_context 713293853
06-03 20:14:32.926+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain hide 713293853
06-03 20:14:32.926+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _render_post_cb(87) > [_render_post_cb], conformant_reset_done = 1
06-03 20:14:32.926+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain hide 713293853
06-03 20:14:32.926+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain focus_out 713293853
06-03 20:14:32.926+0900 D/ISE_WEB_HELPER_AGENT( 2385): websocket.cpp: callback_keyboard(135) > SEND_WEBSOCKET_MESSAGE : plain hide 713293853
06-03 20:14:32.926+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_send_will_hide_ack(976) > conformant_reset_done=1, received_will_hide_event=0
06-03 20:14:32.926+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _event_callback_call(228) > [SECURE_LOG] [input panel has been hidden] ctx : 0xb9277cc0
06-03 20:14:32.926+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: _process_ise_panel_hided(1065) > received_will_hide_event = 1
06-03 20:14:32.926+0900 D/IMMODULE(10883): isf_imf_control_ui.cpp: isf_imf_context_input_panel_send_will_hide_ack(970) > Send will hide ack, conformant_reset_done = 0, received_will_hide_event = 0
06-03 20:14:32.926+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_will_hide_ack(5286) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (58, 1200002)
06-03 20:14:32.926+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: slot_will_hide_ack(5288) > calling ui_candidate_hide (true, false)
06-03 20:14:32.986+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5792) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x1200002, atom : 463
06-03 20:14:32.986+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5848) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
06-03 20:14:32.986+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5865) > calling ui_candidate_hide (true, false)
06-03 20:14:32.986+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5792) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x1200002, atom : 463
06-03 20:14:32.986+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5848) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
06-03 20:14:32.986+0900 D/ISF_PANEL_EFL( 2374): isf_panel_efl.cpp: x_event_window_property_cb(5865) > calling ui_candidate_hide (true, false)
06-03 20:14:32.996+0900 D/PKGMGR_SERVER(12612): pkgmgr-server.c: exit_server(724) > exit_server Start
06-03 20:14:32.996+0900 D/PKGMGR_SERVER(12612): pkgmgr-server.c: main(1516) > Quit main loop.
06-03 20:14:32.996+0900 D/PKGMGR_SERVER(12612): pkgmgr-server.c: main(1524) > package manager server terminated.
06-03 20:14:33.026+0900 D/APP_CORE(10883): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 1
06-03 20:14:33.026+0900 D/APP_CORE(10883): appcore-efl.c: __visibility_cb(897) > bvisibility 0, b_active 1
06-03 20:14:33.026+0900 D/APP_CORE(10883): appcore-efl.c: __visibility_cb(911) >  Go to Pasue state 
06-03 20:14:33.026+0900 D/APP_CORE(10883): appcore-efl.c: __do_app(471) > [APP 10883] Event: PAUSE State: PAUSED
06-03 20:14:33.026+0900 D/APP_CORE(10883): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
06-03 20:14:33.026+0900 E/APP_CORE(10883): appcore-efl.c: __trm_app_info_send_socket(234) > access
06-03 20:14:33.026+0900 D/RESOURCED( 2483): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 10883, type = 2
06-03 20:14:33.026+0900 D/AUL_AMD ( 2277): amd_launch.c: __e17_status_handler(1939) > pid(12757) status(3)
06-03 20:14:33.026+0900 D/RESOURCED( 2483): cpu.c: cpu_background_state(100) > [cpu_background_state,100] cpu_background_state : pid = 10883, appname = uicomponents
06-03 20:14:33.026+0900 D/RESOURCED( 2483): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/service/cgroup.procs, value 10883
06-03 20:14:33.026+0900 I/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/background/cgroup.procs, pid : 10883, oom : 300
06-03 20:14:33.026+0900 E/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/background/cgroup.procs open failed
06-03 20:14:33.026+0900 D/RESOURCED( 2483): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 12757, type = 0
06-03 20:14:33.036+0900 D/RESOURCED( 2483): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 12757
06-03 20:14:33.036+0900 I/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 12757, oom : 200
06-03 20:14:33.036+0900 E/RESOURCED( 2483): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
06-03 20:14:33.086+0900 D/APP_CORE(12757): appcore-efl.c: __show_cb(839) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
06-03 20:14:33.086+0900 D/APP_CORE(12757): appcore-efl.c: __add_win(685) > [EVENT_TEST][EVENT] __add_win WIN:1e00002
06-03 20:14:33.086+0900 D/APP_CORE(12757): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1e00002 fully_obscured 0
06-03 20:14:33.086+0900 D/APP_CORE(12757): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active -1
06-03 20:14:33.086+0900 D/APP_CORE(12757): appcore-efl.c: __visibility_cb(900) >  Go to Resume state
06-03 20:14:33.156+0900 D/APP_CORE(12757): appcore.c: __aul_handler(423) > [APP 12757]     AUL event: AUL_START
06-03 20:14:33.156+0900 D/APP_CORE(12757): appcore-efl.c: __do_app(471) > [APP 12757] Event: RESET State: CREATED
06-03 20:14:33.156+0900 D/APP_CORE(12757): appcore-efl.c: __do_app(497) > [APP 12757] RESET
06-03 20:14:33.156+0900 D/LAUNCH  (12757): appcore-efl.c: __do_app(499) > [gearcon:Application:reset:start]
06-03 20:14:33.156+0900 I/CAPI_APPFW_APPLICATION(12757): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-03 20:14:33.156+0900 D/APP_SVC (12757): appsvc.c: __set_bundle(161) > __set_bundle
06-03 20:14:33.156+0900 D/TUL     (12757): tul_init is needed
06-03 20:14:33.166+0900 E/CAPI_NETWORK_CONNECTION(12757): connection.c: connection_create(360) > Access denied
06-03 20:14:33.166+0900 D/TUL     (12757): connection header fail
06-03 20:14:33.176+0900 E/CAPI_NETWORK_CONNECTION(12757): connection.c: connection_get_ip_address(435) > Invalid parameter
06-03 20:14:33.176+0900 D/TUL     (12757): ip_address not obtained
06-03 20:14:33.226+0900 I/AUL_PAD ( 2297): sigchild.h: __launchpad_sig_child(142) > dead_pid = 12757 pgid = 12757
06-03 20:14:33.226+0900 I/AUL_PAD ( 2297): sigchild.h: __sigchild_action(123) > dead_pid(12757)
06-03 20:14:33.226+0900 D/AUL_PAD ( 2297): sigchild.h: __send_app_dead_signal(81) > send dead signal done
06-03 20:14:33.226+0900 I/AUL_PAD ( 2297): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-03 20:14:33.226+0900 I/AUL_PAD ( 2297): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-03 20:14:33.226+0900 I/AUL_AMD ( 2277): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12757
06-03 20:14:33.226+0900 D/AUL_AMD ( 2277): amd_key.c: _unregister_key_event(161) > ===key stack===
06-03 20:14:33.226+0900 D/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-03 20:14:33.226+0900 E/AUL     ( 2277): simple_util.c: __trm_app_info_send_socket(264) > access
06-03 20:14:33.226+0900 D/STARTER ( 2368): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 12757)
06-03 20:14:33.226+0900 D/AUL_AMD ( 2277): amd_launch.c: __e17_status_handler(1939) > pid(10883) status(3)
06-03 20:14:33.226+0900 W/CRASH_MANAGER(12777): worker.c: worker_job(1189) > 1112757676561149648847

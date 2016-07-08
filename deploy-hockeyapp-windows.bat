curl \
  -F "status=2" \
  -F "notify=1" \
  -F "notes=Some new features and fixed bugs." \
  -F "notes_type=0" \
  -F "ipa=AppTemplate.TDC2016.Windows_1.0.0.0_AnyCPU.appxupload" \
  -F "dsym=AppTemplate.TDC2016.Windows_1.0.0.0_AnyCPU.appxsym" \
  -H "X-HockeyAppToken: 4567abcd8901ef234567abcd8901ef23" \
  https://rink.hockeyapp.net/api/2/apps/1234567890abcdef1234567890abcdef/app_versions/upload
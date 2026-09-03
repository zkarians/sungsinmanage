@echo off
setlocal
cls
echo ========================================================
echo   Starting Sungshin Order Management Modern Desktop App
echo ========================================================
echo.

set "EDGE=C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
set "CHROME=C:\Program Files\Google\Chrome\Application\chrome.exe"
set "PROFILE=C:\Users\Administrator\.sungshin_desktop_profile"
set "URL=http://localhost:5000/"

if exist "%EDGE%" (
    start "" "%EDGE%" --app=%URL% --user-data-dir="%PROFILE%" --window-size=1400,900
    exit
)

if exist "%CHROME%" (
    start "" "%CHROME%" --app=%URL% --user-data-dir="%PROFILE%" --window-size=1400,900
    exit
)

start %URL%
exit
@echo off
setlocal
cls

echo ========================================================
echo   Starting Sungshin Order Management Desktop App
echo ========================================================
echo.

:: 1. Check if backend server is running on port 5000
netstat -ano | findstr ":5000" > nul
if %errorlevel% neq 0 (
    echo Starting Backend Server in background...
    start /min "" python "%~dp0backend\server.py"
    timeout /t 2 /nobreak > nul
)

:: 2. Launch Desktop App Window
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
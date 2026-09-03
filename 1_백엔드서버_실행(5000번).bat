@echo off
title Sungshin Backend Server (Port 5000)
chcp 65001 > nul
cls
echo ========================================================
echo   성신판매접수 백엔드 서버 점검 및 실행
echo ========================================================
echo.

netstat -ano | findstr ":5000" > nul
if %errorlevel% equ 0 (
    echo [안내] 백엔드 서버가 이미 5000번 포트에서 정상 실행 중입니다!
    echo        따로 켜두실 필요 없이 바로 앱(2_PC버전_앱_실행.bat)을 여시면 됩니다.
    echo ========================================================
    timeout /t 4 > nul
    exit
)

echo 백엔드 서버를 구동합니다...
cd /d "%~dp0backend"
python server.py
pause
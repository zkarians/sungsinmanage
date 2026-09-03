@echo off
title Sungshin Backend Server (Port 5000)
echo ========================================================
echo   Starting Sungshin Backend Server (Port: 5000)
echo ========================================================
cd /d "%~dp0backend"
python server.py
pause
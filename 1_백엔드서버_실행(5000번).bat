@echo off
chcp 65001 > nul
echo ========================================================
echo   성신판매접수 로컬 백엔드 서버 구동 (포트: 5000, DB: PostgreSQL)
echo ========================================================
cd /d "D:\Gemini\성신판매접수\backend"
python server.py
pause

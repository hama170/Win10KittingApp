@echo off
setlocal enabledelayedexpansion
cd %~dp0

rem ///引数チェック
if "%1" == "" goto PARAM_ERROR
if NOT EXIST "%1" (
 goto NOT_FOUND_ERROR
)

rem //ユーザー作成




echo 正常終了
exit /B

:PARAM_ERROR
echo パラメータエラー
exit /B

pause
@echo off
setlocal enabledelayedexpansion
cd %~dp0

rem ///�����`�F�b�N
if "%1" == "" goto PARAM_ERROR
if NOT EXIST "%1" (
 goto NOT_FOUND_ERROR
)

rem //���[�U�[�쐬




echo ����I��
exit /B

:PARAM_ERROR
echo �p�����[�^�G���[
exit /B

pause
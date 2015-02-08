@cd "%HOMEDRIVE%%HOMEPATH%\Documents\Visual Studio 2012\Projects\shim\Sources\Shim"

@set SOURCE="%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\"
@set TARGET=_Doc

@if EXIST %TARGET% (rd /s /q %TARGET%)

@md %TARGET%
@xcopy /k /r /v /y %SOURCE%mscorlib.xml %TARGET%
@xcopy /k /r /v /y %SOURCE%System.xml %TARGET%
@xcopy /k /r /v /y %SOURCE%System.Data.xml %TARGET%
@xcopy /k /r /v /y %SOURCE%System.Core.xml %TARGET%
@xcopy /k /r /v /y %SOURCE%System.Xml.xml %TARGET%
@xcopy /k /r /v /y %SOURCE%System.Xml.Linq.xml %TARGET%
@xcopy /k /r /v /y %SOURCE%System.ComponentModel.DataAnnotations.xml %TARGET%

:end
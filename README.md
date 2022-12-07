# HubOffice
 Why choose between MS Office and LibreOffice when you like both?
 Why bother to right-click > open with, when an interface can ask you to do so every time you open?
 That's HubOffice.

## Supported file formats
 `.doc`, `.docx`, `.xls`, `.xlsx`, `.ppt`, `.pptx`

## Instalation
* Add the .ico files you want as thumbnails in the `\ico\` folder (use `doc-file.ico`, `docx-file.ico`, `xls-file.ico`, `xlsx-file.ico`, `ppt-file.ico`, `pptx-file.ico` as names)
* Compile it yourself.
* Copy in `C:\Program Files\HubOffice\`.
* Run `InstalHubOffice.reg`.

## Troubleshooting
* If the files do not open with HubOffice :
 Right-click > Open with > Always open with : HubOffice.
 Re-execute `InstalHubOffice.reg` if needed.
* If MS Office or LibreOffice does not open :
 Find the path to the executables `WINWORD.EXE`, `EXCEL.EXE`, `POWERPNT.EXE`, `swriter.exe`, `scalc.exe`, `simpress.exe`.
 Replace the paths in `MainWindow.xaml.cs`, respectively lines 66, 78,90, 72, 84 & 96.
 Compile.
 Replace files in `C:\Program Files\HubOffice\`.
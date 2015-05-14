csc *.cs
FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    TextBombardment.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
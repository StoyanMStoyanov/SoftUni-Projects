csc *.cs
FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    PiggyBank.exe < "%%f" > "!file:.in.txt=.out.txt!"
)

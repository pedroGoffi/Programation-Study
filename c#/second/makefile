FILE = Main.cs

output: Main.exe
	mono Main.exe

Main.exe: Main.cs
	mcs -optimize Main.cs

clean:
	rm *.exe

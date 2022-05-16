main: main.o
	ld -o main main.o
	./main
main.o: main.asm
	nasm -felf64 main.asm
clean:
	rm *.o

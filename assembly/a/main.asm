format ELF64 executable 3
;; ---- BITS 64 ----- ;;   
segment readable executable
entry start
return:
  mov rax, 60
  mov rdi, 0
  
  syscall
  ret
start:
  mov rax, 1
  mov rdi, 1
  mov rsi, hello
  mov rdx, 13
  syscall

  call return 

  
segment readable writable
hello: db "Hello world", 10
	

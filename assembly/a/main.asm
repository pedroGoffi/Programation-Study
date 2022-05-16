BITS 64
%include "/usr/include/goffiLang/stdGlib.s"

global _start
section .text
_start:
  push 2
  push 2
  equal
  push rcx

  pop rdi
  call dump


  mov eax, 1
  mov rdi, 0
  int 0x80



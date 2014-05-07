@echo off
cl.exe  %1 user32.lib kernel32.lib gdi32.lib msimg32.lib winmm.lib %2 %3 %4 %5 %6 %7 %8 %9 /wd4996 /wd4716

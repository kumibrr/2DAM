from tkinter import *

window = Tk()
window.geometry("400x300+0+0")
window.configure(background='red')
window.title(window.geometry())

window2 = Tk()
window2.geometry("400x300-0-0")
window2.configure(background='pink')
window2.title(window.geometry())

window3 = Tk()
window3.geometry("400x300-0+0")
window3.configure(background='purple')
window3.title(window.geometry())

window4 = Tk()
window4.geometry("400x300+0-0")
window4.configure(background='orange')
window4.title(window.geometry())

window.mainloop()
window2.mainloop()
window3.mainloop()
window4.mainloop()

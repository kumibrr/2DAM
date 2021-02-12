from tkinter import *

window = Tk()
window.geometry("800x200")
window.configure(background='pink')
window.title(window.geometry())

labelOneToTen = Label(window, text="Números (1 al 10)")
labelThousand = Label(window, text="Números (1000 al 2000)")
labelOneToTen.pack(side=TOP, anchor=NE, padx=20, pady=20, ipadx=30, ipady=14, fill=BOTH, expand=FALSE)

window.mainloop()
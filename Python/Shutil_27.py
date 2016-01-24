import shutil
import os
import Tkinter


def moveFiles():
    userHome = os.path.expanduser('~')
    source = userHome + "\Desktop\Folder A"
    files = os.listdir(source)
    destination = userHome + "\Desktop\Folder B"

    for textFile in files:
        shutil.move(os.path.join(source,textFile), destination)
        print "The new filepath for", textFile, "is:", os.path.join(destination, textFile)

root = Tkinter.Tk()
button = Tkinter.Button(root, text = "Move Files", command = moveFiles)
button.pack()

root.mainloop()

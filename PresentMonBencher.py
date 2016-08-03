import csv, os
# Initialise lists and variables
PresentMs = []
PresentFPS = []
PresentTime = []
# Get filename and load
workingdirectory = "C:\PresentMonLauncher"
print "Directory: ", workingdirectory
print
os.chdir(workingdirectory)
for file in os.listdir(workingdirectory):
    if file.endswith(".csv"):
        print(file)
print        
pmfilename = raw_input("Which file to analyze?: ")
if not pmfilename.endswith(".csv"):
   pmfilename = pmfilename+ ".csv"

print pmfilename + " was successfully loaded"
# Load file
pmfile = open(pmfilename,"r")
line = pmfile.readline()
# Loop until the end of the file
for line in pmfile:
   # Create PresentMs list data
   blocks = line.split(",")
   PresentTime.append(blocks[9])
   PresentTime = map(float, PresentTime)
   PresentMs.append(blocks[10])
   PresentMs = map(float, PresentMs)
   # Create PresentFPS array data
for item in PresentMs:
    fps = 1000/float(item)
    PresentFPS.append(fps)
avgfps = len(PresentMs)/round(PresentTime[-1], 0)
minfps = min(PresentFPS)
maxfps = max(PresentFPS)
print "Minimum FPS: ", minfps
print "Maximum FPS: ", maxfps
print "Average FPS: ", avgfps
minmaxavg = "Minimum " + str(minfps) + "\nMaximum " + str(maxfps) + "\nAverage " + str(avgfps) + "\n"
minmaxavgfilename = "MinMaxAvg.txt"
with open("MinMaxAvg.txt", "a") as text_file:
    text_file.write(minmaxavg + "\n")
print "File saved as " + minmaxavgfilename   
# Save file as .csv
outputfilename = raw_input("Enter Name of Output File: ")
if not outputfilename.endswith(".csv"):
   outputfilename = outputfilename+ ".csv"
zip(PresentMs, PresentFPS)
with open(outputfilename, "w") as f:
   writer = csv.writer(f, delimiter=',', lineterminator='\n')
   writer.writerows(zip(PresentTime, PresentMs, PresentFPS))
print "File saved as " + outputfilename

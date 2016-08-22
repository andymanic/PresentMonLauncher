#To do:
#   -clean up the log_menu function so that it only displays the menu and refrences the nessecary functions.
#   -move the extra functionality from log_menu to its own seperate function
#   -remove spelling errors(haven't checked but these have almost certainly been made)
#   -come up with better names for some variables, functions and classes
#   -Make the install directory variable
#   -[More notes almost certainly to come]

from Bencher import Bencher
import os, csv, itertools
directory = "C:\PresentMonLauncher"
os.chdir(directory)
#The Runner class collects all the data, processes the user input and calls the bencher class
class Runner():
    def __init__(self, workdir):
        self.workingdirectory = workdir
        self.csv_files_dict = {}
        self.bench_file = None
    #function to make initiate all the functionality
    def run(self):
        self.analyser()
        self.bench_file = self.select_file(self.csv_files_dict)
        print self.bench_file
        self.menu()

        
    #scans for .csv files and puts the in a dictionary       
    def analyser(self):
        print(self.workingdirectory)
        i = 1
        for file in os.listdir(self.workingdirectory):
            
            if file.endswith(".csv"):
                self.csv_files_dict[i] = file
                i += 1
    #pretty prints a dictionary                
    def pprint_dict(self, dictionary):
         for item in dictionary:
             print item, ":", dictionary[item]
    #creates an interface to select a file    
    def select_file(self, dictionary):
        self.pprint_dict(dictionary)
        file = dictionary[int(input("please select one of the files by entering its corresponding number : "))]
        return file
    
    #menu with several options for extracting files
    def menu(self):
        bench = Bencher(self.bench_file, self.workingdirectory)
        bench.opener()
        bench.calc_frametime_fps()
        menu_display_dict = {1 : "log FPS and frame times to file",
                             2 : "calculate minimum, maximum and average FPS",
                             3 : "all of the above"
                             }
        
        menu_action_dict = {1 : [bench.get_frametime, bench.get_fps],
                            2 : [bench.get_min, bench.get_max, bench.get_avg],
                            3 : [bench.get_frametime, bench.get_fps, bench.get_min, bench.get_max, bench.get_avg]
                            }
      
        self.pprint_dict(menu_display_dict)
        choice = int(input("please select one of the options by entering its corresponding number : "))
        menu_item = menu_action_dict[choice]
        self.log_menu(menu_item)

    
    #menu with functionality to choose a file to log to, reading and writing(there last to should get their own functions soon)       
    def log_menu(self, benches):
        self.analyser()
        print "please select a file to log to (the log will be appended to the existing data in the file.)"
        log_file = self.select_file(self.csv_files_dict)
        formatted_data = []
        with open(log_file, "rb") as open_file:
            reader = csv.reader(open_file)
            bench_data = []
            write_data = []
            read_data = []
            if(os.stat(log_file).st_size > 0):
                line = next(reader)
                read_data = [[] for x in range(len(line))]
                for index, item in enumerate(line):
                    read_data[index].append(item)
                for row in open_file:
                    blocks = row.split(",")
                    for index, value in enumerate(blocks):
                        try:
                            value = float(value)
                        except:
                            pass
                        try:
                            value = value.strip("\n")
                        except:
                            pass
                        read_data[index].append(value)
            for bench in benches:
                bench_data.append(bench())
            bench_data[0].insert(0, self.bench_file)
            iter_bench = iter(bench_data)
            prev = next(iter_bench, None)
            for bench in iter_bench:
                bench.insert(0, None)
            write_data.extend(read_data)                    
            write_data.extend(bench_data)
            formatted_data = itertools.izip_longest(*write_data)
        with open(log_file, "wb") as input_file:
            writer = csv.writer(input_file, lineterminator="\n")
            for item in formatted_data:
                writer.writerow(item)
            
        
        
run = Runner(directory)
run.run()


            
    

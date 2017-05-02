#pathfinding 

from collections import deque

graph = []

class Node():
    def __init__(self, value):
        self.value = value

class Grid():
    def __init__(self, x,y):
        self.graph = Grid.makegrid(x,y)[0]      #dictionary that has lists of tuples of neighbor coordinates
        self.grid = Grid.makegrid(x,y)[1]
        self.nodes = Grid.makegrid(x,y)[2]      #dictionary that has coordinates as tuples but empty list of neighbors
        self.x = x
        self.y = y
    
    def findShortestPath(self, startTuple, targetTuple):
        
        startNeighbors = self.graph[startTuple]
        targetNeighbors = self.graph[targetTuple]
        shortestPath = []
        
        #set up queues    
        visited = deque()
        allnodes = self.nodes.keys()
        unvisited = deque()
        
        #set start node
        #allnodes[startTuple] = "Current"
        
        sdx = targetTuple[0] - startTuple[0]    #ideal distance x
        sdy = targetTuple[1] - startTuple[1]    #ideal distance y
        
        #if i can traverse diagonally, figure out the best right triangle to achieve this distance
        #or just iteratively move horizontally and vertically one space each move
        nextX = startTuple[0]
        nextY = startTuple[1]
        while (sdx != 0) or (sdy != 0):
            if sdy > 0:
                #then we move down
                nextY+=1
                sdy-=1
            elif sdy < 0:
                #then we move up
                nextY-=1
                sdy+=1
            #sdy-=nextY
            
            if sdx > 0:
                #then we move right
                nextX+=1
                sdx-=1
            elif sdx < 0:
                #then we move left
                nextX-=1
                sdx+=1
            #sdx-=nextX
            
            shortestPath.append((nextX,nextY))
    
        return shortestPath

    
    def printShortestPath(self, start, target):
        shortestpath = self.findShortestPath(start,target)
        pathgrid = self.grid
        pathgrid[start[0]][start[1]] = "S"
        
        for n in shortestpath:
            pathgrid[n[0]][n[1]] = "x"
        
        pathgrid[target[0]][target[1]] = "F"
        
        for i in range(len(pathgrid)):
            print pathgrid[i]
        
        print("")
        
        for i in range(len(pathgrid)):
            for j in range(len(pathgrid)):
                pathgrid[i][j] = " "
    
    @staticmethod
    def makegrid(x,y):
        #make a x-by-y grid
        graphofNodes = {}
        grid = []
        nodes = {}
        for i in range(x):
            row = []
            for j in range(y):
                row.append(" ")
                # nodes[(i,j)] = []
                nodes[(i,j)] = None     #initialize to none to represent unvisited
                graphofNodes[(i,j)] = []     #each coordinate is keyed to a tuple value that has all of the neighbors for that coordinate
                #fill the neighbors by subtrcting/adding 1 in different combinations
                if (i-1 >=0): graphofNodes[(i,j)].append([i-1,j])
                if ((i-1 >= 0) and (j-1 >=0)): graphofNodes[(i,j)].append([i-1,j-1])
                if ((i-1 >= 0) and (j+1 < y)): graphofNodes[(i,j)].append([i-1,j+1])
                if (i+1 < x): graphofNodes[(i,j)].append([i+1,j])
                if ((i+1 < x) and (j-1 >= 0)): graphofNodes[(i,j)].append([i+1,j-1])
                if ((i+1 < x) and (j+1 < y)): graphofNodes[(i,j)].append([i+1,j+1])
                if (j+1 < y): graphofNodes[(i,j)].append([i,j+1])
                if (j-1 >= 0): graphofNodes[(i,j)].append([i,j-1])
                #then erase any neighbors with at least one negative coordinate; this neighbor is outside the grid
            
            grid.append(row)
    
        return [graphofNodes,grid,nodes]
        
    


mygrid = Grid(7,8)
# print(mygrid.graph)
#print(mygrid.findShortestPath((1,0),(5,0)))
mygrid.printShortestPath((1,0),(5,0))
#print(mygrid.findShortestPath((2,1),(6,4)))
mygrid.printShortestPath((2,1),(6,4))
#print(mygrid.findShortestPath((7,3),(0,7)))




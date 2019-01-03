#
    #  1,2,5,4,2,4
      
    #  1. Find min and max(wall)
    #  2. Find the wall previuse element is greater than current
    #  3.  as this is wall if prevouse element array[i-1] is less than or equal to wall 
    #  then add to memory nstrokes. and set min and strokes to zero,
    #  4. calculate strokes wall - min.
    #  5. Repeate calculation again
  #

def FindStrokes(array):
    strokes = 0
    m = array[0]
    wall = array[0]

    totalStrokes = 0
    
    for i in range(len(array)):
      m = min(array[i],m)
      wall = max(array[i],wall)
      if array[i] < array[i-1] and i > 0:
        if array[i-1] >= wall:
          totalStrokes = totalStrokes + strokes
          strokes = 0
        m = array[i]


      strokes = wall - m

    return strokes + totalStrokes

print(FindStrokes([1,2,5,4,2,4]))
print(FindStrokes([7,3,2]))
print(FindStrokes([7,3,2,10]))
print(FindStrokes([2,2,3,10,2,1]))

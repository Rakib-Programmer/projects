# Leap Year using if else statement in python.
#year=int(input( "Enter Your Year:"))
#if (year%4==0 and year%100!=0) or (year%400==0):
 #   print("This is leap year")
#else:
 #   print(" This is not leap year")

year=int(input( "Enter Your Year:"))
if (year%4==0 and year%100!=0) or (year%400==0):
    print(year,"is leap year")
else:
    print(year,"is not leap year")
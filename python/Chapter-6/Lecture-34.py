import math
a=int(input("Please Enter the first value:"))
b=int(input("Please Enter the second velue:"))
c=int(input("Please Enter the thrid velue:"))
D=b*b-4*a*c
if D>0:
    x1=-b+math.sqrt(D)/2*a
    x2=-b-math.sqrt(D)/2*a
    print("Root are real but unequal:",x1,x2)
elif D==0:
    x=-b/2*a
    print("Root are real and equal:",x)
else:
    print("Root are imginary")
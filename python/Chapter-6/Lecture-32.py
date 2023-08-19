import math
a=float(input("Please Enter Your First arm:"))
b=float(input("Please Enter Your second arm:"))
c=float(input("Please Enter Your Third arm:"))
if a+b>c and b+c>a and c+a>b:
    s=a+b+c/2
    area=math.sqrt(s*(s-a)*(s-b)*(s-c))
    print("Your Area is",area)
else:
    print("Triangle is not passible")
a=input('Enter desired string or value: ')
U=L=D=S=SP=0
for i in a:
    if i.isupper():
        U+=1
    elif i.islower():
        L+=1
    elif i.isdigit():
        D+=1
    elif i.isspace():
        S+=1
    else:
        SP+=1
print(f'The no. of uppercase letters is {U}')
print(f'The no. of lowercase letters is {L}') 
print(f'The no. of digits is {D}')
print(f'The no. of spaces is {S}')
print(f'The no. of special characters is {SP}')

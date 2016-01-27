def numSort(num):
    #Before sort
    print(num)
    x = 0
    while x < (len(num)-1):
        if num[x] > num[x+1]:
            num[x], num[x+1] = num[x+1], num[x]
            #print(num)
            x += 1
            if x == (len(num)-1):
                x = 0
        elif num[x] < num[x+1]:
            x = 0
            for i in num:
                if num[x] == max(num):
                    break
                if num[x] < num[x+1]:
                    x += 1
                else:
                    break
        else:
            break
    #After sort
    print(num)

       
num = [67, 45, 2, 13, 1, 998]
numSort(num)

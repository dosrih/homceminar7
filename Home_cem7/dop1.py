N = int(input())

a = []

for i in range(N):
    b = list(map(int, input().split()))
    a.append(b)

for i in range(N):
    i=N-i-1
    for j in range(N):
        j=N-j-1
        print(a[j][i], end=' ')
    print()

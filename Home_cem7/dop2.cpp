int main(){
    int n, m;
    cin >> n >> m;
    char ss1[101][101], ss2[101][101];
    for (int i = 0; i < n; ++i)
        cin >> ss1[i];
    for (int i = 0; i < n; ++i)
        cin >> ss2[i]
    int res = 0;
    for (int i = 0; i < n; ++i)
        for (int j = 0; j = m; ++j)
            res += ss1 [i][j] == ss2[i][j];
    cout << res;
    return 0;                    
}
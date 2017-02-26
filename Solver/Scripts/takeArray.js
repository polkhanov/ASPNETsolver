
var n = 10, m = 10;

var mas = [];
var mas2 = [];
for (var i = 0; i < m; i++) {
    
    mas[i] = [];
    
    for (var j = 0; j < n; j++) {
        
        mas[i][j] = 0;
        
    }
}
var index_i = 0, index_j = 0;
$("input").each(function () {
    mas2[index_i] = $(this).val();
    index_i++;

    console.log(mas2);
});
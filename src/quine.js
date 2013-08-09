var newLine = String.fromCharCode(10);
var data = 'var newLine = String.fromCharCode(10);%3var data = %1%0%1;%3console.log(data.replace(/%21/g, "%1").replace(/%23/g, newLine).replace(/%22/g, "%").replace("%20", data));';
console.log(data.replace(/%1/g, "'").replace(/%3/g, newLine).replace(/%2/g, "%").replace("%0", data));
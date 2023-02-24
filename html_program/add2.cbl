<html>
<h1 align-center>mkpits</h1>
<hr>
<body>
enter num1=<input type="text" id="n1">
enter num2=<input type="text" id="n2">
<input type="button" value="id" onclick="addNum();">
</body>
<script language="javascript">
function addNum()
{
var num1,num2,result;
num1=parseInt(document.getElementById("n1");
num2=parseInt(document.getElementById("n2");
result=num1+num2;
alert("addition is"+result);
}
</script>
</html>

object quine extends App {
	val quote = 34.toChar
	var newLine = 10.toChar
	val data = """object quine extends App {%2$s	val quote = 34.toChar%2$s	var newLine = 10.toChar%2$s	val data = %1$s%1$s%1$s%3$s%1$s%1$s%1$s%2$s	println(data format (quote, newLine, data))%2$s}"""
	println(data format (quote, newLine, data))
}

package main

import "fmt"

func main() {
	fmt.Println(reverseString("Reverse Me!"))
}

func reverseString(str string) string {
	strArray := []rune(str)
	for i, j := 0, len(strArray)-1; i < j; i, j = i+1, j-1 {
		strArray[i], strArray[j] = strArray[j], strArray[i]
	}
	return string(strArray)
}

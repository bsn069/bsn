package main
import (
    "net/http"
	"fmt"
)
func main() {
    fmt.Println("http://localhost:10001/");
    var dir = http.Dir("./../../")
    fmt.Printf("dir=%s", dir)
    http.Handle("/", http.FileServer(dir))
    http.ListenAndServe(":10001", nil)
}
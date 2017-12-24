package pangram

import (
	"strings"
)

const testVersion = 1

func IsPangram(s string) bool {
	alphabet := strings.Split("abcdefghijklmnopqrstuvwxyz", "")
	letters := strings.Split(s, "")

	for _, l := range letters {
		for x, a := range alphabet {
			if strings.ToLower(a) == strings.ToLower(l) {
				alphabet = append(alphabet[:x], alphabet[x+1:]...)
			}
		}
	}

	if len(alphabet) == 0 {
		return true
	}

	return false
}

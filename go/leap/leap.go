package leap

const testVersion = 3

// IsLeapYear checks if a given year is a leap year
func IsLeapYear(year int) bool {
	if year%4 == 0 && (year%400 == 0 || year%100 != 0) {
		return true
	}

	return false
}

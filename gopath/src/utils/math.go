package utils

func MinU32(u32L, u32R uint32) uint32 {
	if u32L <= u32R {
		return u32L
	}
	return u32R
}

func MaxU32(u32L, u32R uint32) uint32 {
	if u32L >= u32R {
		return u32L
	}
	return u32R
}

// return min,max
func MinMaxU32(u32L, u32R uint32) (uint32, uint32) {
	return MinU32(u32L, u32R), MaxU32(u32L, u32R)
}

// return u32M between u32L, u32R
func BoundU32(u32L, u32M, u32R uint32) uint32 {
	u32L, u32R = MinMaxU32(u32L, u32R)
	return MinU32(MaxU32(u32L, u32M), u32R)
}

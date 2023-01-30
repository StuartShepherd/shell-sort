# Shell Sort

Shell sort is a comparison-based sorting algorithm that is a variation of insertion sort. Like insertion sort, it works by comparing elements with their neighbours and swapping them if they are out of order. However, unlike insertion sort, it uses a gap (or increment) value to compare elements that are farther apart. This gap value is gradually decreased as the algorithm proceeds, eventually reaching a value of 1, at which point the sort is effectively an insertion sort. 

The idea behind using a gap value is that by comparing elements that are farther apart, it can move larger elements to their final positions more quickly, resulting in fewer overall comparisons and swaps.
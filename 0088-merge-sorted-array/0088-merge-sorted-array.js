  function merge(nums1, m, nums2, n) {
    p1=m-1;
    p2=n-1;
    last=(m+n)-1;
    while(p1>=0&&p2>=0){
    if(nums1[p1]>nums2[p2]){
        nums1[last]=nums1[p1]
        p1--
    }else{
        nums1[last]=nums2[p2]
        p2--
    }
    last--;
    }
    while(p2>=0){
        nums1[last]=nums2[p2];
        p2--
        last--
    }
    return nums1;
    
    
}



        
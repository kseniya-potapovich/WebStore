import React, {useEffect, useState} from 'react';
import Header from "../../components/Header";
import Store from "../../components/Store";
import {getAllProduct} from "../../API/API";

const RootPage = () => {
    const [products, setProducts] = useState([])
    useEffect(() => {
        getAllProduct().then(r=>{
            setProducts(r.data)
        })
    }, []);
    return (
        <div>
            <Header/>
            <Store products={products}/>
        </div>
    );
};

export default RootPage;
import React from 'react';
import StoreCard from "../StoreCard";
import styles from './styles.module.css'
const Store = ({products}) => {
    return (
        <div className={styles.wrap}>
            {products ?  products.map((e,i)=>{
                return <div key={`${i}-product`}>
                    <StoreCard product={e}/>
                </div>
            }): <div>Не найдено продуктов</div>}
        </div>
    );
};

export default Store;
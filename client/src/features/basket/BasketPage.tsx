import { Typography } from "@mui/material";
import { useEffect, useState } from "react";
import agent from "../../app/api/agent";
import {Basket} from "../../app/models/basket";


export default function BasketPage()
{
    const [loading, setLoading] = useState(true);
    const [basket, setBasket] = useState<Basket | null>(null);

    useEffect(() => {
        agent.Basket.get()
        .then(basket => setBasket(basket))
        .catch(error => console.log(error))
        .finally(() => setLoading(false))
    }, [])

   if(!basket) return <Typography>Your Basket is empty</Typography>

    return (
        <h1>Basket</h1>
    )
}